using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zadanie2
{
    public class Bootstrap : MonoBehaviour
    {
        [SerializeField] private PlayerController _playerController;

        private void Awake()
        {
            _playerController.SetInput(new DesktopInput(_playerController));
        }
    }
}

