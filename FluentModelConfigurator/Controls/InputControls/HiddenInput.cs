namespace FluentModelConfigurator
{
    public class HiddenInput : Input<HiddenInput>
    {
        protected override HiddenInput GetThis
        {
            get { return this; }
        }

        private string Type
        {
            set { this.Type = InputType.hidden.ToString(); }
        }

    }
}
