using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediateka.core.Entity
{
    class AudioElement : IElement
    {
        public string Name { get ; set; }

        public TimeSpan Duration { get; }
        public bool IsExecuting { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Execute()
        {
            if (!IsExecuting)
            {
                //Do some work
            }

        }
    }
}
