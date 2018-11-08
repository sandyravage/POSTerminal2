using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace POSTerminal3
{
    class PlayerMaker
    {
        public static SoundPlayer MakeSoundPlayer(string input)
        {
            return new SoundPlayer($@"C:\Users\TEVERTS\source\repos\POSTerminal3\POSTerminal3\Resources\{input}.wav");
        }
    }
}
