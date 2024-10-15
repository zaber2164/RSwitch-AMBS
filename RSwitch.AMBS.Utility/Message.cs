using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSwitch.AMBS.Utility
{
    public class Message
    {
        private MessageType _Type = MessageType.Information;
        private string _Msg;

        public MessageType Type
        {
            get { return _Type; }
            set { _Type = value; }
        }

        public string Msg
        {
            get { return _Msg; }
            set { _Msg = value; }
        }

        public Message()
        {
        }

        public Message(MessageType type, String msg)
        {
            this._Type = type;
            this._Msg = msg;
        }

        public void Clear()
        {
            _Msg = "";
            _Type = MessageType.Information;
        }
    }

    public enum MessageType
    {
        Information,
        Warning,
        Error
    }
}
