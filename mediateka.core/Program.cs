using mediateka.Entity;
using mediateka.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediateka
{
    class Program
    {
        public static void Main(string[] args)
        {
            IView view = new ConsoleView();
            List<BaseElement> playList = new List<BaseElement>()
            {
                new AudioElement("Yesterday.mp3"),
            new VideoElement("Matrix.mkv"),
            new ImageElement("Nature.jpg"),
            new VideoElement("Avengers: The end Game.mkv"),
            new ImageElement("C# hotkeys.jpg")
            };
            MediaList mediaList = new MediaList(playList);
            Mediateka mediateka = new Mediateka(view, mediaList);
            view.Show("\n---------Before sorting--------------\n");
            mediateka.ShowPlaylist();
            mediateka.Start();
            mediateka.Playlist.Sort(ElementCompareType.Name);
            view.Show("\n---------After sorting--------------\n");
            mediateka.ShowPlaylist();
            Console.ReadLine();

        }
    }
}
