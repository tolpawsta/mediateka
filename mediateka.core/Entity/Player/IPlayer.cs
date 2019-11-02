using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediateka.core.Entity.Player
{
    public interface IPlayer
    {
        void Play(IElement element);
        void Remove(IElement element);
        ICollection<IElement> PlayList { get; set; }
    }
}
