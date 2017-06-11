using System;

namespace MMEncryptor.Utils
{
    //TODO: may be generic type, but i am not sure
    public class Serializer<T>
    {
        public byte[] Serialize(T toSerialize)
        {
            var binFormat = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            var stream = new System.IO.MemoryStream();
            binFormat.Serialize(stream, toSerialize);
            byte[] buffer = stream.ToArray();
            stream.Close();

            return buffer;
        }

        public T Deserialize(byte[] toDeserialize)
        {
            //TODO: implement
            var binFormat = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            var streamToDeserialize = new System.IO.MemoryStream(toDeserialize);
            T buffer = (T)binFormat.Deserialize(streamToDeserialize);
            streamToDeserialize.Close();
            
            return buffer;
        }
    }
}
