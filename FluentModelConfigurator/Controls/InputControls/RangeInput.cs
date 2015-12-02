namespace FluentModelConfigurator
{
    public class RangeInput:Input<RangeInput>
    {
        protected override RangeInput GetThis
        {
            get { return this; }
        }

        private string Type;
        private string ControlType;

        public RangeInput()
        {
            this.Type = InputType.range.ToString();
            this.ControlType = ControlTypes.RangeInput.ToString();
        }

        private ushort MinVal;
        private ushort MaxVal;

        public RangeInput WithMinValue(ushort minVal)
        {
            MinVal = minVal;
            return this;
        }

        public RangeInput WithMaxValue(ushort maxVal)
        {
            MaxVal = maxVal;
            return this;
        }
    }
}
