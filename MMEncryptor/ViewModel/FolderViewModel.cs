using MMEncryptor.Model;

namespace MMEncryptor.ViewModel
{
    class FolderViewModel : AbstractContainerViewModel
    {
        public FolderViewModel(FolderContainer component) : base(component)
        {                   

        }
        public override string Type => "Folder";
        public override string Size => "";
    }
}

