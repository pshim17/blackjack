using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack
{
    internal class Dealer
    {
        public Hand hand { get; }

        public Dealer()
        {
            hand = new Hand();
        }
    }
}
