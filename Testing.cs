using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assessment_1_Jack_Wilson_26364588_Version_3
{
    internal class Testing
    {
        static Pack pack1 = new Pack();
        bool hasRun = pack1.shuffleCardPack(1);
        List <Card> deck1 = pack1.dealCard(52);

        static Pack pack2 = new Pack();
        
        bool hasRun2 = pack2.shuffleCardPack(2);
        List<Card> deck2 = pack2.dealCard(52);
        static Pack pack3 = new Pack();
        bool hasRun3=pack3.shuffleCardPack(3);
		List<Card> deck = pack3.dealCard(52);
    }
}
