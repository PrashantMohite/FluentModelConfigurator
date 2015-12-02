namespace FluentModelConfigurator
{
    public class HiddenInput : Input<HiddenInput>
    {
        private string Type;

        private string ControlType;

        protected override HiddenInput GetThis
        {
            get { return this; }
        }

        public HiddenInput()
        {
            this.Type = InputType.hidden.ToString();
            this.ControlType = ControlTypes.HiddenInput.ToString();
        }
    }
}
