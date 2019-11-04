using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediateka.Entity
{
    public class VideoElement : BaseElement
    {
        public VideoElement(string name)
        {
            Name = name;
        }
        public override string getStream()
        {
            return "Playing video - "+Name;

        }
    }
}
