using System;
using System.IO;

namespace MMEncryptor.Model
{
    [Serializable]
    public abstract class AbstractContainer
    {
        public FolderContainer Parent { get; set; } = null;

        public string Name { get; set; }
        public DateTime LastWriteTime { get; private set; }

        public AbstractContainer() { }

        protected AbstractContainer(string name, DateTime lastWriteTime)
        {
            Name = name;
            LastWriteTime = lastWriteTime;
        }

        protected static bool IsDirectory(FileInfo file)
        {
            return (file.Attributes & FileAttributes.Directory) == FileAttributes.Directory;
        }
    }
}
