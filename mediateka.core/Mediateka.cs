using mediateka.core;
using mediateka.Entity;
using mediateka.Entity.Player;
using mediateka.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace mediateka
{
    class Mediateka
    {
        IView view;
       public MediaList Playlist { get; }
        Player player;
        public Mediateka(IView view, MediaList playlist)
        {
            this.view = view;
            Playlist = playlist;
        }
        public void Start()
        {
            
            if (Playlist == null)
            {
                throw new NullReferenceException();
            }
            view.Show("--------Playing Files------------");
            foreach (BaseElement element in Playlist)
            {
                
                if (element is AudioElement)
                {
                    player = new AudioPlayer(view);
                }
                if (element is VideoElement)
                {
                    player = new VideoPlayer(view);
                }
                if (element is ImageElement)
                {
                    player = new ImageViewer(view);
                }
                Thread.Sleep(2000);
                player.Play(element);
            }
            view.Show("----------End Playlist-------------");
        }
        
        public void ShowPlaylist()
        {
            foreach (BaseElement  item in Playlist)
            {
                view.Show(item.ToString());
            }
        }
    }
}
