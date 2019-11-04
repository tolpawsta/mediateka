using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediateka.Entity
{
    public class ImageElement : BaseElement
    {

        public ImageElement(string name)
        {
            Name = name;
        }
        public override string getStream()
        {
            return "Opened image - "+Name;
        }
    }
}
