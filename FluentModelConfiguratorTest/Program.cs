using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentModelConfigurator;

namespace FluentModelConfiguratorTest
{


    public class Customer
    {
        public int ID { get; set; }
        public string name { get; set; }
    }
    public class CustomerForm : Customer
    {
        List<string> EmailValidation;
        private FluentModelConfigurator.Form<Customer> __form;
        public CustomerForm()
        {
            __form=new Form<Customer>();
            EmailValidation = new List<string>();
            EmailValidation.Add("Please Enter correct Email address");
            __form.AddPropertyAsEmailInput(x => x.name).WithRequired(true).WithMaxLength(15).WithName("Email").WithLabel("Client Email").WithValidationMessageList(EmailValidation);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CustomerForm customerForm = new CustomerForm();
            
        }
    }
}
