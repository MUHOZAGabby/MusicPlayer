using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PandaPlayer 
{
    class HipHop : Song
    {
        public string HipHopSound { get; private set; }

    public HipHop(string newArtistOfSong, string newTitleOfSong, string newHipHopSound) : base(newArtistOfSong, newTitleOfSong)
        {
            this.HipHopSound = newHipHopSound;
        }

        public override string ToString()
        {
            return base.ToString() + " " + HipHopSound;
        }
        public override void Play()
        {
            base.Play();
            Console.WriteLine(" " + HipHopSound);
        }
    }
}
