using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediateka.core.Entity.Player
{
    class AudioPlayer : IMediaPlayer
    {
        public ICollection<IElement> PlayList { get; set; } = null;

        public void Pause()
        {
            
        }

        public void Play(IElement element)
        {
            element.Execute();
        }

        public void Remove(IElement element)
        {
            //TODO: organize removing element from Playlist
            PlayList.Remove(element);
        }

        public void Stop()
        {
            
        }
    }
}
