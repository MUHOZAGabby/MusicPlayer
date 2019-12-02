 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PandaPlayer
{
    abstract class Song
    {
        public string artistOfSong { get; private set; }
        public string titleOfSong { get; private set; }

        public Song(string newArtistOfSong, string newTitleOfSong)
        {
            this.artistOfSong = newArtistOfSong;
            this.titleOfSong = newTitleOfSong; 
        }
        public override string ToString()
        {
            return this.artistOfSong + " " + this.titleOfSong;
        }

        public virtual void Play()
        {
            Console.Write(artistOfSong + " " + titleOfSong);
        }


    }
}
