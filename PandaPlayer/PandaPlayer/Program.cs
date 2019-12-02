using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PandaPlayer
{
    class Program
    {
        static void Main(string[] args)
        { string decision;
            do
            {
                Console.WriteLine("Select Genre: ");
                string inputGenre = Console.ReadLine();
                Console.WriteLine("Select Artist: ");
                string inputArtist = Console.ReadLine();
                Console.WriteLine("Select Title: ");
                string inputTitle = Console.ReadLine();


                Song song;
                Song hiphop = new HipHop(inputArtist, inputTitle, inputGenre);
                try
                {
                    Player player = new Player();
                    player.AddSong(hipHop);
                    player.RemoveSong(2);
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                    Console.WriteLine("Do you want to add another Song: click Y  or N");
                decision = Console.ReadLine();

            }
            while (decision == "Y" || decision == "y");
     


            //    Console.WriteLine(hipHop);
            //hipHop.Play();

           

            
           // player.AddSong(song);
        }
    }
}
