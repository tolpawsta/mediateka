using mediateka.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediateka.Entity.Player
{
    public abstract class Player
    {
       protected IView view;
       public string Name { get; protected set; }

        public string AboutFile { get; protected set; }
        public abstract void Play(BaseElement element);
        
       
    }
}
