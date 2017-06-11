using System;
using System.IO;
using System.Linq;

namespace MMEncryptor.Model
{
    [Serializable]
    public class FileContainer : AbstractContainer
    {
        public string Extention
        {
            get
            {
                return $".{Name.Split('.').Last()}";
            }
        }

        public int Size => Content.Length;

        public byte[] Content { get; private set; }

        public FileContainer() { }

        public FileContainer(FileInfo file)
            :base(file.Name, file.LastAccessTime)
        {
            if (IsDirectory(file))
            {
                throw new ArgumentException($"File {file.Name} is a directory, but worked with as a file.");
            }
            
            using (FileStream fstream = file.OpenRead())
            {
                Content = new byte[fstream.Length];
                fstream.Read(Content, 0, Content.Length);
            }
        }
    }
}
