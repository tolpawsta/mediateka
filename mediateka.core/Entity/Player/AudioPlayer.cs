using mediateka.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediateka.Entity.Player
{
    class AudioPlayer : Player
    {
        
        public AudioPlayer(IView view)
        {
            this.view = view;
        }
        public override void Play(BaseElement element)
        {
           view.Show(element.getStream());
        }
    }
}
