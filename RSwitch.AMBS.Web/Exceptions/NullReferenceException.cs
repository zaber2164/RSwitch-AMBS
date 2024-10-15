using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSwitch.AMBS.Utility.Exceptions
{
    public class ArgumentNullReferenceException : Exception
    {
        public ArgumentNullReferenceException() : base()
        {

        }

        public ArgumentNullReferenceException(string message) : base(message)
        {

        }

        public ArgumentNullReferenceException(string message, Exception ex) : base(message, ex)
        {

        }
    }
}
