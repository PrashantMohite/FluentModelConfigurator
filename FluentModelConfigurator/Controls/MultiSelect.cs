using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentModelConfigurator
{
    public class MultiSelect : Input<MultiSelect>
    {
        protected override MultiSelect GetThis
        {
            get { return this; }
        }
        private string Type
        {
            set { this.Type = ""; }
        }
        private string ControlType
        {
            set { this.ControlType = ControlTypes.MultiSelect.ToString(); }
        }
        private string Placeholder;

        public MultiSelect WithPlaceHolder(string placeholder)
        {
            Placeholder = placeholder;
            return this;
        }

        private List<string> OptionCollection;

        public MultiSelect WithOptionCollection(List<string> optionCollection)
        {
            OptionCollection = optionCollection;
            return this;
        }
    }
}
