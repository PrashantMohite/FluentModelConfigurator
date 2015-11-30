using System.Collections.Generic;

namespace FluentModelConfigurator
{
    public class RadioInput : Input<RadioInput>
    {
        protected override RadioInput GetThis
        {
            get { return this; }
        }

        private string Type
        {
            set { this.Type = InputType.radio.ToString(); }
        }
        private string ControlType
        {
            set { this.ControlType = ControlTypes.RadioInput.ToString(); }
        }
        public List<string> Values;

        public RadioInput WithValues(List<string> values)
        {
            Values = values;
            return this;
        }

    }
}
