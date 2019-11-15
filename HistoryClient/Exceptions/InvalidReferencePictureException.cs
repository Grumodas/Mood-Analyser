using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistoryClient.Exceptions
{
    class InvalidReferencePictureException : System.Exception
    {
        public InvalidReferencePictureException()
        {

        }

        public InvalidReferencePictureException(string message) : base(message)
        {
        }

        public InvalidReferencePictureException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}
