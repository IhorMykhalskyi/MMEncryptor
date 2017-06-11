using MMEncryptor.Model;
using System;

namespace MMEncryptor.ViewModel
{
    public abstract class AbstractContainerViewModel
    {
        protected readonly AbstractContainer _component;

        public string Name => _component.Name;
        public DateTime LastChange => _component.LastWriteTime;
        public virtual string Type { get; }
        public virtual string Size { get; }


        protected AbstractContainerViewModel(AbstractContainer component)
        {
            _component = component;
        }
    }
}
