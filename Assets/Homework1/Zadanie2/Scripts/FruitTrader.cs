using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zadanie2
{
    public class FruitTrader : Trader
    {
        protected override void SetupTrader()
        {
            _thisTraderTypeBehavior = new TradeFruitsBehavior();
        }
    }
}
