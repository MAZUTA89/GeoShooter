using InputCode;
using System;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace WeaponLogic
{
    public class ShootingRig : MonoBehaviour
    {
        Animator _animator;
        int _shiootingCode;
        InputService _inputService;
        [Inject]
        public void Construct(InputService inputService)
        {
            _inputService = inputService;
        }
        private void Start()
        {
            _animator = GetComponent<Animator>();
            _shiootingCode = Animator.StringToHash("IsShooting");
        }

        private void Update()
        {
            _animator.SetBool(_shiootingCode, _inputService.IsShoot());
        }
    }
}
