using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Zadanie2
{
    public class ArmorTrader : Trader
    {
        protected override void SetupTrader()
        {
            _thisTraderTypeBehavior = new TradeArmorBehavior();
        }
    }
}

