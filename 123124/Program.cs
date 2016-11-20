using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace _123124
{
    class Program
    {
        static void Main(string[] args)
        {
            SoundPlayer myPlayer = new System.Media.SoundPlayer();            
            myPlayer.SoundLocation = @"C:\1118.wav";
            myPlayer.PlaySync();
           
        }
    }
}
