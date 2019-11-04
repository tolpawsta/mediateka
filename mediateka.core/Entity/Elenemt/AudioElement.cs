using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediateka.Entity
{
    class AudioElement : BaseElement
    {
        public AudioElement(string name)
        {
            Name = name;
        }
        public override string getStream()
        {
            return "Playing audiofile - "+ Name;

        }
    }
}
