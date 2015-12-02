using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentModelConfigurator
{
    public class ComboBox : Input<ComboBox>
    {
        protected override ComboBox GetThis
        {
            get { return this; }
        }

        private string Type;

        private string ControlType;
       
        public ComboBox()
        {
            this.Type = "";
            this.ControlType = ControlTypes.ComboBox.ToString();
        }
        private string Placeholder;

        public ComboBox WithPlaceHolder(string placeholder)
        {
            Placeholder = placeholder;
            return this;
        }

        private List<string> OptionCollection;

        public ComboBox WithOptionCollection(List<string> optionCollection)
        {
            OptionCollection = optionCollection;
            return this;
        }        
    }
}
