using System.Collections.Generic;

namespace FluentModelConfigurator
{
    public class RadioInput : Input<RadioInput>
    {

        private string Type;

        private string ControlType;
        protected override RadioInput GetThis
        {
            get { return this; }
        }

        public RadioInput()
        {
            this.Type = InputType.radio.ToString();
            this.ControlType = ControlTypes.RadioInput.ToString();
        }

        private List<string> Values;

        public RadioInput WithValues(List<string> values)
        {
            Values = values;
            return this;
        }

    }
}
