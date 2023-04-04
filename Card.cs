using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assessment_1_Jack_Wilson_26364588_Version_3
{
    internal class Card
    {
        //Base for the Card class.
        //Value: numbers 1 - 13
        //Suit: numbers 1 - 4
        //The 'set' methods for these properties could have some validation
        public Pack.Value value { get; set; }
        public Pack.Suit suit { get; set; }
    }
}
