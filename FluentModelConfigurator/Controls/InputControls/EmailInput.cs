﻿namespace FluentModelConfigurator
{
    public class EmailInput : Input<EmailInput>
    {
        protected override EmailInput GetThis
        {
            get { return this; }
        }

        private string Type
        {
            set { this.Type = InputType.email.ToString(); }
        }

        private ushort Length;

        public EmailInput WithMaxLength(ushort lenght)
        {
            Length = lenght;
            return this;
        }
    }
}