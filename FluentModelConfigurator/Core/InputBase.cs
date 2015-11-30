using System.Collections.Generic;

namespace FluentModelConfigurator
{
    public abstract class InputBase
    {
        protected string Label { get; set; }

        protected string Name { get; set; }

        protected List<string> ValidationMessageList { get; set; }
    }

    public abstract class Input<TEntity> : InputBase
    {
        protected abstract TEntity GetThis { get; }

        #region required

        private bool IsRequired { get; set; }

        public TEntity WithRequired(bool requierd = true)
        {
            IsRequired = requierd;
            return GetThis;
        }

        public TEntity WithValidationMessageList(List<string> validationMessageList)
        {
            ValidationMessageList = validationMessageList;
            return GetThis;
        }

        public TEntity WithLabel(string label)
        {
            Label = label;
            return GetThis;
        }

        public TEntity WithName(string name)
        {
            Name = name;
            return GetThis;
        }

        #endregion
    }
}
