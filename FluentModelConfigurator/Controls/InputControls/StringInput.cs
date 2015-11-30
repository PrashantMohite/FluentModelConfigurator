namespace FluentModelConfigurator
{
    public class StringInput : Input<StringInput>
    {
        protected override StringInput GetThis
        {
            get { return this; }
        }
        private string Type
        {
            set { this.Type =InputType.text.ToString(); }
        }
        private string ControlType
        {
            set { this.ControlType = ControlTypes.StringInput.ToString(); }
        }

        private ushort MaxLength { get; set; }
        private int ValueRange { get; set; }
        private ushort MinLength { get; set; }
        private string RegularExpression { get; set; }

        public StringInput WithMaxLength(ushort length)
        {
            MaxLength = length;
            return this;
        }

        public StringInput WithMinLength(ushort length)
        {
            MinLength = length;
            return this;
        }

        public StringInput WithLength(ushort length)
        {
            MinLength = length;
            MaxLength = length;
            return this;
        }

        public StringInput WithRegularExpression(string regularExpression)
        {
            RegularExpression = regularExpression;
            return this;
        }
    }
}
