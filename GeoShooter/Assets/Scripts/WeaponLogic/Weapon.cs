using Enemies;
using GameSO;
using InputCode;
using PlayerCode;
using System;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace WeaponLogic
{
    public class Weapon : MonoBehaviour
    {
        [SerializeField] private Transform _bulletPoint;
        [SerializeField] private ParticleSystem _hitParticle;
        InputService _inputService;
        WeaponSO _weaponSO;
        float _currentDelayTime;
        float _delayTime;
        bool _IsDelay;
        Player _player;
        [Inject]
        public void Construct(InputService inputService,
            WeaponSO weaponSO, Player player)
        {
            _inputService = inputService;
            _weaponSO = weaponSO;
            _player = player;
        }
        public void Start()
        {
            _currentDelayTime = 0f;
            _delayTime = 1 / _weaponSO.Speed;
            _IsDelay = false;
        }

        public void Update()
        {
            if (_IsDelay)
            {
                _currentDelayTime += Time.deltaTime;
                if (_currentDelayTime >= _delayTime)
                {
                    _currentDelayTime = 0f;
                    _IsDelay = false;
                }
            }

            if (_inputService.IsShoot() &&
                _IsDelay == false)
            {

                Shoot();
                _IsDelay = true;
            }
        }

        public void Shoot()
        {
            Ray ray = new Ray(_bulletPoint.position,
                _bulletPoint.transform.forward);

            if (Physics.Raycast(ray, out RaycastHit hit, 20f))
            {
                var obj = hit.collider.gameObject;
                var direction = hit.point - _player.transform.position;

                Instantiate(_hitParticle, hit.point,
                Quaternion.LookRotation(direction), null);

                Debug.Log($"{obj.name}");
                if (obj.TryGetComponent(out Enemy enemy))
                {
                    enemy.TakeDamage(_weaponSO.Damage);
                }
            }
        }
    }
}
