using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediateka.Entity
{
    public abstract class BaseElement
    {
       public string Name { get; set; }
       public string FileInfo {get;}

        public abstract String getStream();

        bool IsStreaming { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
