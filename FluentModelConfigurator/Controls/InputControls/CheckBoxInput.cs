using System.Collections.Generic;

namespace FluentModelConfigurator
{
    public class CheckBoxInput: Input<CheckBoxInput>
    {
        protected override CheckBoxInput GetThis
        {
            get { return this; }
        }

        private string Type
        {
            set { this.Type = InputType.checkbox.ToString(); }
        }
        private List<string> Values;

        public CheckBoxInput WithValues(List<string> values)
        {
            Values = values;
            return this;
        }
    }
}
