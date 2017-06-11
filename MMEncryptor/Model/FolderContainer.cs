using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MMEncryptor.Model
{
    [Serializable]
    public class FolderContainer : AbstractContainer
    {
        private List<AbstractContainer> _containers = new List<AbstractContainer>();

        public FolderContainer() { }

        private FolderContainer(string name, DateTime lastWriteDate)
            :base(name, lastWriteDate) { }

        public static FolderContainer CreateEmpty(string name)
        {
            return new FolderContainer(name, DateTime.Now);
        }

        public static FolderContainer Create(DirectoryInfo dirInfo)
        {
            FolderContainer result = new FolderContainer(dirInfo.Name, dirInfo.LastWriteTime);
            result.Add( 
                from folder in dirInfo.GetDirectories()
                select Create(folder)
                );
            result.Add(
                from info in dirInfo.GetFiles()
                select new FileContainer(info)
                );
            return result;
        }

        public static FolderContainer Create(IEnumerable<FileInfo> fileInfos)
        {
            if (fileInfos.Count() == 0)
            {
                throw new ArgumentException("Empty file list.");
            }

            if (fileInfos.Count() == 1)
            {
                FileInfo file = fileInfos.Single();
                if (IsDirectory(file))
                {
                    return Create(new DirectoryInfo(file.FullName));
                }
                else
                {
                    FolderContainer folder = CreateEmpty(file.Name);
                    folder.Add(new FileContainer(file));
                    return folder;
                }
            }

            FolderContainer result = CreateEmpty(fileInfos.First().Directory.Name);
            result.Add(
                from folder in fileInfos
                where IsDirectory(folder)
                select Create(new DirectoryInfo(folder.FullName))
                );
            result.Add(
                from info in fileInfos
                where ! IsDirectory(info)
                select new FileContainer(info)
                );
            return result;
        }

        public void Remove(AbstractContainer container)
        {
            RemoveByName(container.Name);
        }

        public void RemoveByName(string name)
        {
            AbstractContainer comp = GetChildOrDefault(name);
            if (comp == null)
            {
                throw new ArgumentException($"There is no container with name: {name}");
            }
            _containers.Remove(comp);
        }

        public void Add(AbstractContainer containerToAdd)
        {
            if (Contains(containerToAdd.Name))
            {
                throw new ArgumentException($"Folder {Name} already contains folder with name {containerToAdd.Name}");
            }
            containerToAdd.Parent = this;
            _containers.Add(containerToAdd);
        }

        public void Add(IEnumerable<AbstractContainer> containersToAdd)
        {
            foreach (var file in containersToAdd)
            {
                Add(file);
            }
        }

        public bool Contains(string childName)
        {
            return (_containers.SingleOrDefault(x => x.Name == childName)) != null;
        }

        public IEnumerable<AbstractContainer> GetChildren()
        {
            return _containers;
        }

        public AbstractContainer GetChildOrDefault(string childName)
        { 
            return _containers.SingleOrDefault(x => x.Name == childName);
        }
    }
}
