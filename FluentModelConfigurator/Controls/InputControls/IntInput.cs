namespace FluentModelConfigurator
{
    public class IntInput : Input< IntInput>
    {
        protected override IntInput GetThis
        {
            get { return this; }
        }

        private string Type
        {
            set { this.Type = InputType.number.ToString(); }
        }

        private string ControlType
        {
            set { this.ControlType = ControlTypes.NumericInput.ToString(); }
        }

        private ushort MaxLength { get; set; }
        private int ValueRange { get; set; }

        public IntInput WithMaxLength(ushort length)
        {
            MaxLength = length;
            return this;
        }

        public IntInput WithMinLength(ushort length)
        {
            MinLength = length;
            return this;
        }

        public IntInput WithLength(ushort length)
        {
            MinLength = length;
            MaxLength = length;
            return this;
        }

        public IntInput WithMinValue(int minRange)
        {
            minRange = ValueRange;
            return this;
        }

        public IntInput WithmaxValue(int maxRange)
        {
            maxRange = ValueRange;
            return this;
        }

        private ushort MinLength { get; set; }
    }
}