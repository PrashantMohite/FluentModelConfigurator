using System.Collections.Generic;

namespace FluentModelConfigurator
{
    public class CheckBoxInput: Input<CheckBoxInput>
    {
        private string Type;
        private string ControlType;
        protected override CheckBoxInput GetThis
        {
            get { return this; }
        }

        public CheckBoxInput()
        {
            this.Type = InputType.checkbox.ToString();
            this.ControlType = ControlTypes.CheckBox.ToString();
        }
  
        private List<string> Values;

        public CheckBoxInput WithValues(List<string> values)
        {
            Values = values;
            return this;
        }
    }
}
