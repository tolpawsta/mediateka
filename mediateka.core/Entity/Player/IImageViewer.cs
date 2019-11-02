using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediateka.core.Entity.Player
{
    interface IImageViewer:IPlayer
    {
        void Rotate(IElement element);
    }
}
