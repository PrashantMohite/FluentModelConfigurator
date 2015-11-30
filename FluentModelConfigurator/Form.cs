using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace FluentModelConfigurator
{
    public class Form<TEntity> where TEntity : class
    {
        public List<InputBase> PropertyList { get; set; }

        public Form()
        {
            PropertyList = new List<InputBase>();
        }

        public IntInput AddPropertyAsIntInput(Expression<Func<TEntity, int>> expr)
        {
            var prop = new IntInput();
            PropertyList.Add(prop);
            return prop;
        }

        public StringInput AddPropertyAsStringInput(Expression<Func<TEntity, string>> expr)
        {
            var prop = new StringInput();
            PropertyList.Add(prop);
            return prop;
        }

        public RadioInput AddPropertyAsRadioInput(Expression<Func<TEntity, bool>> expr)
        {
            var prop = new RadioInput();
            PropertyList.Add(prop);
            return prop;
        }
        public CheckBoxInput AddPropertyAsCheckBoxInput(Expression<Func<TEntity, bool>> expr)
        {
            var prop = new CheckBoxInput();
            PropertyList.Add(prop);
            return prop;
        }

        public DateInput AddPropertyAsDateInput(Expression<Func<TEntity, DateTime>> expr)
        {
            var prop = new DateInput();
            PropertyList.Add(prop);
            return prop;
        }

        public EmailInput AddPropertyAsEmailInput(Expression<Func<TEntity, string>> expr)
        {
            var prop=new EmailInput();
            PropertyList.Add(prop);
            return prop;
        }

        public HiddenInput AddPropertyAsHiddenInput(Expression<Func<TEntity, string>> expr)
        {
            var prop=new HiddenInput();
            PropertyList.Add(prop);
            return prop;
        }
        public PasswordInput AddPropertyAsPasswordInput(Expression<Func<TEntity, string>> expr)
        {
            var prop = new PasswordInput();
            PropertyList.Add(prop);
            return prop;
        }
        public RangeInput AddPropertyAsRangeInput(Expression<Func<TEntity, int>> expr)
        {
            var prop = new RangeInput();
            PropertyList.Add(prop);
            return prop;
        }

        public ComboBox AddPropertyAsComboBox(Expression<Func<TEntity, string>> expr)
        {
            var prop = new ComboBox();
            PropertyList.Add(prop);
            return prop;
        }
        public MultiSelect AddPropertyAsMultiselect(Expression<Func<TEntity, string>> expr)
        {
            var prop = new MultiSelect();
            PropertyList.Add(prop);
            return prop;
        }
        public TextArea AddPropertyAsTextArea(Expression<Func<TEntity, string>> expr)
        {
            var prop = new TextArea();
            PropertyList.Add(prop);
            return prop;
        }
        public FileUpload AddPropertyAsFileUpload(Expression<Func<TEntity, string>> expr)
        {
            var prop = new FileUpload();
            PropertyList.Add(prop);
            return prop;
        }
        
        public Slider AddPropertyAsSlider(Expression<Func<TEntity, string>> expr)
        {
            var prop = new Slider();
            PropertyList.Add(prop);
            return prop;
        }
    }
}