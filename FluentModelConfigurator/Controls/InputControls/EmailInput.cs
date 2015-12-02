namespace FluentModelConfigurator
{
    public class EmailInput : Input<EmailInput>
    {
        private string ControlType;

        private ushort Length;
        private string Type;
        protected override EmailInput GetThis
        {
            get { return this; }
        }
        public EmailInput()
        {
            this.ControlType = ControlTypes.Email.ToString();
            this.Type = InputType.email.ToString();
        }
        public EmailInput WithMaxLength(ushort lenght)
        {
            Length = lenght;
            return this;
        }
    }
}
