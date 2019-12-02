using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PandaPlayer
{
    class Player
    {
        List<Song> playList = new List<Song>();
        
        public void AddSong(Song song)
        {
            playList.Add(song); 
        }

        public void RemoveSong(int songNumber)
        {
          //  playList.Remove(songNumber);
        }
        public void PlayList(int songNumber)
        {

        }
    }
}
