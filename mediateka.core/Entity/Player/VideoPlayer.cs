using mediateka.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediateka.Entity.Player
{
    class VideoPlayer : Player
    {
        public VideoPlayer(IView view)
        {
            this.view = view;
        }
        public override void Play(BaseElement element)
        {
           view.Show(element.getStream());
        }
    }
}
