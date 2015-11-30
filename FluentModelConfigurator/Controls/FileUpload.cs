using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentModelConfigurator
{
    public class FileUpload :Input<FileUpload>
    {
        protected override FileUpload GetThis
        {
            get { return this; }
        }
        private string Type
        {
            set { this.Type = InputType.file.ToString(); }
        }
        private string ControlType
        {
            set { this.ControlType = ControlTypes.FileUpload.ToString(); }
        }
    }
}
