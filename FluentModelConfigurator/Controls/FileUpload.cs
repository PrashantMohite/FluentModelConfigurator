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

        private string Type;

        private string ControlType;

        public FileUpload()
        {
            this.Type = InputType.file.ToString();
            this.ControlType = ControlTypes.FileUpload.ToString();
        }
    }
}
