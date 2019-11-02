using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediateka.core.Entity.Player
{
   public interface IMediaPlayer:IPlayer
    {
        void Stop();
        void Pause();
    }
}
