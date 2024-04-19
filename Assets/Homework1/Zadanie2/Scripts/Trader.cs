using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Самое оптимальное решение которое пришло в голову, реализовать выбор стратегии через enum
namespace Zadanie2
{
    public abstract class Trader : MonoBehaviour
    {
        protected TraderBehavior _traderBehavior;
        protected TraderBehavior _thisTraderTypeBehavior;

        private void Start()
        {
            SetupTrader();
        }

        public void Interact(Reputation reputation)
        {
            switch (reputation)
            {
                case Reputation.LowReputation:
                    _traderBehavior = new NoTradeBehavior();
                    break;
                case Reputation.HighReputation:
                    _traderBehavior = _thisTraderTypeBehavior;
                    break;
            }

            _traderBehavior?.Trade();

        }

        protected abstract void SetupTrader();
    }
}

