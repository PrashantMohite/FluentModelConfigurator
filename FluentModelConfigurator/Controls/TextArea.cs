using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentModelConfigurator
{
    public class TextArea : Input<TextArea>
    {
        protected override TextArea GetThis
        {
            get { return this; }
        }

        private string Type;

        private string ControlType;

        public TextArea()
        {
            this.Type = "";
            this.ControlType = ControlTypes.TextArea.ToString();
        }
        private ushort Rows;
        private ushort Columns;

        public TextArea WithRows(ushort rows)
        {
            Rows = rows;
            return this;
        }

        public TextArea WithColumns(ushort columns)
        {
            Columns = columns;
            return this;
        }

    }
}
