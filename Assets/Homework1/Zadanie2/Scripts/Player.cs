using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zadanie2
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private Reputation _reputation;
        public Reputation Reputation => _reputation;
        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent(out Trader trader))
            {
                trader.Interact(Reputation);
            }
        }

        
    }
}

