using System;
using System.Runtime.Serialization;

namespace HistoryClient
{
    [Serializable]
    public class InvalidReferencePictureException : Exception
    {
        public InvalidReferencePictureException()
        {
        }

        public InvalidReferencePictureException(string message) : base(message)
        {
        }

        public InvalidReferencePictureException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidReferencePictureException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}