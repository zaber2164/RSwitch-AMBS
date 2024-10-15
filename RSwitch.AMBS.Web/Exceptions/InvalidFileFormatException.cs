using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSwitch.AMBS.Utility.Exceptions
{
    public class InvalidFileFormatException : Exception
    {
        public InvalidFileFormatException() : base()
        {
        }

        public InvalidFileFormatException(string message) : base(message)
        {

        }
        public InvalidFileFormatException(string message, Exception ex) : base(message, ex)
        {

        }
    }
}
