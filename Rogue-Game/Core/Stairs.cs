using RLNET;
using RogueSharp;
using RogueSharpV3Tutorial.Core;
using RogueSharpV3Tutorial.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Rogue_Game.Core
{
    public class Stairs : IDrawable
    {
        public RLColor Color { get; set; }

        public char Symbol { get; set; }

        public int X { get; set; }

        public int Y { get; set; }

        public void Draw(RLConsole console, IMap map)
        {
            if (!map.GetCell(X, Y).IsExplored)
            {
                return;
            }
            Symbol = '<';

            console.Set(X, Y, RLColor.LightMagenta, RLColor.Yellow, Symbol,0);
        }

    }
}
