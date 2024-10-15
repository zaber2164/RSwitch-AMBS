using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSwitch.AMBS.Utility
{
    [AttributeUsage(AttributeTargets.Property)]
    public class PropertyAttribute: Attribute
    {
        protected Attributes _Attribute;

        public enum Attributes
        {
            PrimaryKey = 1,
            AutoIncrement = 2,
            Index = 3,
            NonTable = 4,
            General = 5
        }

        public Attributes Attribute
        {
            get { return _Attribute; }
            set { _Attribute = value; }
        }

        public PropertyAttribute(Attributes attribute)
        {
            this._Attribute = attribute;
        }
    }
}
