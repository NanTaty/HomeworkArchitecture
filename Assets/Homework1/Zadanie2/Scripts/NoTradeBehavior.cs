using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zadanie2
{
    public class NoTradeBehavior : TraderBehavior
    {
        public override void Trade()
        {
            Debug.Log("I do not trade with you");
        }
    }
}

