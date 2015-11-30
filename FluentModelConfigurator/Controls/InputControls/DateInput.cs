using System;

namespace FluentModelConfigurator
{
    public class DateInput : Input<DateInput>
    {
        protected override DateInput GetThis
        {
            get { return this; }
        }

        private string Type
        {
            set { this.Type = InputType.date.ToString(); }
        }

        private string MaxDate;
        private string MinDate;

        public DateInput WithMinDate(DateTime minDate)
        {
            MinDate = minDate.ToShortDateString();
            return this;
        }

        public DateInput WithMaxDate(DateTime maxDate)
        {
            MaxDate = maxDate.ToShortDateString();
            return this;
        }
        
    }
}