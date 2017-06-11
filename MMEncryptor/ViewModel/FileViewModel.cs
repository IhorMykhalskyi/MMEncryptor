using MMEncryptor.Model;

namespace MMEncryptor.ViewModel
{
    public class FileViewModel : AbstractContainerViewModel
    {
        private const int FromByteToKByte = 7;

        public override string Type => (_component as FileContainer).Extention;
        
        // TODO: add MB and others with norm algorithm (non critical)
        public override string Size => $"{(_component as FileContainer).Size >> FromByteToKByte + 1} KB"; 

        public FileViewModel(FileContainer container) : base(container)
        {
        }
    }
}
