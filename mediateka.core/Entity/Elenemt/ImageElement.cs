using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediateka.core.Entity
{
    public class ImageElement : IElement
    {
        public string Name { get; set; }

        public TimeSpan Duration { get; }
        //? Need it?
        public bool IsExecuting { get; set; } = false;

        public void Execute()
        {
           //Do some work
        }
    }
}
