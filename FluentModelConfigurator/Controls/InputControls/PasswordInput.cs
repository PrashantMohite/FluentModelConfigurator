namespace FluentModelConfigurator
{
    public class PasswordInput : Input<PasswordInput>
    {
        protected override PasswordInput GetThis
        {
            get { return this; }
        }

        private string Type;

        private string ControlType;
        public PasswordInput()
        {
            this.Type = InputType.password.ToString();
            this.ControlType = ControlTypes.PassWordInput.ToString();
        }


        private ushort MaxLength { get; set; }
        private int ValueRange { get; set; }
        private ushort MinLength { get; set; }
        private string RegularExpression { get; set; }

        public PasswordInput WithMaxLength(ushort length)
        {
            MaxLength = length;
            return this;
        }

        public PasswordInput WithMinLength(ushort length)
        {
            MinLength = length;
            return this;
        }

        public PasswordInput WithLength(ushort length)
        {
            MinLength = length;
            MaxLength = length;
            return this;
        }

        public PasswordInput WithRegularExpression(string regularExpression)
        {
            RegularExpression = regularExpression;
            return this;
        }
    }
}
