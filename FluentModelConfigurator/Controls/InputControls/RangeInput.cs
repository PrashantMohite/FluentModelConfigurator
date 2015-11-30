namespace FluentModelConfigurator
{
    public class RangeInput:Input<RangeInput>
    {
        protected override RangeInput GetThis
        {
            get { return this; }
        }

        private string Type
        {
            set { this.Type = InputType.range.ToString(); }
        }
        private string ControlType
        {
            set { this.ControlType = ControlTypes.RangeInput.ToString(); }
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
