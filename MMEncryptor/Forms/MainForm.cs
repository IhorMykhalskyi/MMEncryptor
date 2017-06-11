using MMEncryptor.Model;
using System;
using System.IO;
using MMEncryptor.Utils;
using System.Windows.Forms;
using System.Linq;
using MMEncryptor.ViewModel;
using System.Collections.Generic;
using System.Security.Cryptography;
using constants = MMEncryptor.Constants.Constants;
using System.Diagnostics;

namespace MMEncryptor.Forms
{
    public partial class MainForm : Form
    {
        private FolderContainer _rootContainer;
        private FolderContainer _currentContainer;
        private FileInfo _mmeFileInfo;
        private string _secretKey;

        public MainForm()
        {
            InitializeComponent();
            
            SetPanelButtonEnable(false);            
        }

        private void createNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateNewMmeForm form = new CreateNewMmeForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                _mmeFileInfo = new FileInfo(form.FullName);
                _rootContainer = FolderContainer.Create(form.FileInfos);
                _currentContainer = _rootContainer;
                SaveFirst();
                (new KeyShowForm(_secretKey)).ShowDialog();
                FillCatalog();                
            }
        }

        private void AddFileButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fileDialog = new OpenFileDialog())
            {
                fileDialog.Multiselect = false;                
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileContainer fileContainer = new FileContainer(new FileInfo(fileDialog.FileName));
                    _currentContainer.Add(fileContainer);
                    Save();
                    FillCatalog();
                }
            }
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            AbstractContainer toOpen = GetContainerForSelectedRow();
            if (! (toOpen is FolderContainer))
            {
                throw new ArgumentException("Only Folders can be opened.");
            }
            _currentContainer = toOpen as FolderContainer;
            FillCatalog();            
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            AbstractContainer toRemove = GetContainerForSelectedRow();
            _currentContainer.Remove(toRemove);
            Save();
            FillCatalog();
        }

        private void CatalogDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            SetOpenButtonText();
        }

        private void textBoxFilePath_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxFilePath.Text))
            {
                SetPanelButtonEnable(false);
            }
            else
            {
                SetPanelButtonEnable(true);
            }
        }

        private void buttonCreateEmptyFolder_Click(object sender, EventArgs e)
        {
            CreateEmptyFolderForem form = new CreateEmptyFolderForem();
            if(form.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            _currentContainer.Add(FolderContainer.CreateEmpty(form.Name));
            Save();
            FillCatalog();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenMmeFile();
        }

        private void buttonChooseMmeFile_Click(object sender, EventArgs e)
        {
            OpenMmeFile();
        }

        private void buttonExctract_Click(object sender, EventArgs e)
        {
            AbstractContainer containerToExtract = GetContainerForSelectedRow();
            ExtractAndShow(containerToExtract);
        }

        private void Save()
        {
            Serializer<AbstractContainer> serializer = new Serializer<AbstractContainer>();
            byte[] serializedContainer = serializer.Serialize(_rootContainer);
            Security.Encrypt(serializedContainer, _mmeFileInfo.FullName, _secretKey);
            FillCatalog();
        }

        private void SaveFirst()
        {
            Serializer<AbstractContainer> serializer = new Serializer<AbstractContainer>();
            byte[] serializedContainer = serializer.Serialize(_rootContainer);
            _secretKey = Security.Encrypt(serializedContainer, _mmeFileInfo.FullName);
        }

        private void InitRootContainer(string mmeFilePath, string key)
        {
            byte[] container;
            try
            {
                container = Security.Decrypt(mmeFilePath, key);
            }
            catch (CryptographicException e)
            {
                throw;
            }
            Serializer<FolderContainer> serializer = new Serializer<FolderContainer>();
            _rootContainer = serializer.Deserialize(container);
        }

        private void FillCatalog()
        {
            IEnumerable<FolderViewModel> folderModels = from folderContainer in _currentContainer.GetChildren()
                                                        orderby folderContainer.Name ascending
                                                        where folderContainer is FolderContainer
                                                        select new FolderViewModel(folderContainer as FolderContainer);
            IEnumerable<FileViewModel> fileModels = from fileContainer in _currentContainer.GetChildren()
                                                    orderby fileContainer.Name ascending
                                                    where fileContainer is FileContainer
                                                    select new FileViewModel(fileContainer as FileContainer);

            List<AbstractContainerViewModel> modelList = new List<AbstractContainerViewModel>();
            modelList.AddRange(folderModels);
            modelList.AddRange(fileModels);

            panelCatalog.Enabled = true;
            CatalogDataGridView.DataSource = null;
            CatalogBindingSource.DataSource = modelList;
            CatalogDataGridView.DataSource = CatalogBindingSource;

            if (_currentContainer?.Parent != null)
            {
                buttonBack.Enabled = true;
            }
            else
            {
                buttonBack.Enabled = false;
            }
        }

        private AbstractContainer GetContainerForSelectedRow()
        {
            string name = CatalogDataGridView.
                SelectedRows[0].
                Cells[nameof(_currentContainer.Name)].
                Value.ToString();
            return _currentContainer.GetChildOrDefault(name);
        }

        private void SetOpenButtonText()
        {
            if (CatalogDataGridView.SelectedRows.Count == 0)
            {
                return;
            }
            if (GetContainerForSelectedRow() is FolderContainer)
            {
                buttonOpen.Enabled = true;
            }
            else if (GetContainerForSelectedRow() is FileContainer)
            {
                buttonOpen.Enabled = false;
            }
        }

        private void OpenMmeFile()
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.DefaultExt = constants.MME_FILE_EXTENTION.Remove(0, 1);
            openDialog.AddExtension = true;
            openDialog.Filter = constants.MME_FILE_FILTER;
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                string key = TryAskForKey(openDialog.FileName);
                if (key == null)
                {
                    return;
                }

                _secretKey = key;
                textBoxFilePath.Text = openDialog.FileName;
                _mmeFileInfo = new FileInfo(openDialog.FileName);                    
                _currentContainer = _rootContainer;
                FillCatalog();
            }
        }

        private string TryAskForKey(string pathToFile)
        {
            string key = AskForKey();
            if (key == null)
            {
                return null;
            }

            try
            {
                InitRootContainer(pathToFile, key);
            }
            catch (CryptographicException)
            {
                MessageBox.Show("Wrong key. Try again.", "Wrong Key", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return TryAskForKey(pathToFile);
            }

            return key;
        }

        private string AskForKey()
        {
            KeyEnterForm form = new KeyEnterForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                return form.Key;
            }
            else
            {
                return null;
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (_currentContainer.Parent != null)
            {
                _currentContainer = _currentContainer.Parent;
            }
            FillCatalog();
        }

        private void ExtractAllButton_Click(object sender, EventArgs e)
        {
            ExtractAndShow(_rootContainer);
        }

        private void ExtractAndShow(AbstractContainer container)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Extract(container, dialog.SelectedPath);
                string argument = "/select, " + Path.Combine(dialog.SelectedPath, container.Name);
                Process.Start(dialog.SelectedPath, argument);
            }
        }

        private void Extract(AbstractContainer container, string path)
        {
            if (container is FileContainer)
            {
                File.WriteAllBytes(
                    Path.Combine(path, container.Name),
                    (container as FileContainer).Content
                    );
            }
            if (container is FolderContainer)
            {
                string pathForChildren = Path.Combine(path, container.Name);
                Directory.CreateDirectory(pathForChildren);
                foreach (AbstractContainer children in ((FolderContainer)container).GetChildren())
                {
                    Extract(children, pathForChildren);
                }
            }
        }

        private void SetPanelButtonEnable(bool enable)
        {
            AddButton.Enabled = enable;
            buttonCreateEmptyFolder.Enabled = enable;
            buttonExctract.Enabled = enable;
            RemoveButton.Enabled = enable;
            ExtractAllButton.Enabled = enable;
            buttonOpen.Enabled = enable;
            buttonBack.Enabled = enable;
        }
    }
}
