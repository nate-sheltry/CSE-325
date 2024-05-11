using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Dunham
{
    public class DeskQuote
    {
        private int width;
        private int depth;
        private string surfaceType;

        private int drawers;
        private int shipping;

        public DeskQuote(int width, int depth, string surfaceType, int drawers = 0, int shipping = 14)
        {
            this.width = width;
            this.depth = depth;
            this.surfaceType = surfaceType;
            this.drawers = drawers;
            this.shipping = shipping;
        }
        public string produceQuote()
        {
            return "Quote :P";
        }
    }
}
