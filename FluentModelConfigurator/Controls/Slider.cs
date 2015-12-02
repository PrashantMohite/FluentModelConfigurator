using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentModelConfigurator
{
    public class Slider : Input<Slider>
    {
        protected override Slider GetThis
        {
            get { return this; }
        }

        private string Type;
        private string ControlType;

        public Slider()
        {
            this.Type = "";
            this.ControlType = ControlTypes.Slider.ToString();
        }

        private List<int> ValueCollection;

        public Slider WithValueCollection(List<int> valueCollection)
        {
            ValueCollection=new List<int>();
            ValueCollection = valueCollection;
            return this;
        }
    }
}
