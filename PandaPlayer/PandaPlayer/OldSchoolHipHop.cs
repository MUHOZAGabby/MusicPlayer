using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PandaPlayer
{
    class OldSchoolHipHop : HipHop
    {
        public string oldSchoolHipHopSound;

        public OldSchoolHipHop(string newArtistOfSong, string newTitleOfSong ,string newOldSchoolSound): base(newArtistOfSong,newTitleOfSong,newOldSchoolSound)
        {
            this.oldSchoolHipHopSound = newOldSchoolSound;
        }

        public override string ToString()
        {
            return base.ToString() + " " + oldSchoolHipHopSound;
        }
        public override void Play()
        {
            base.Play();
            Console.WriteLine(" " + oldSchoolHipHopSound);
        }

    }
}
