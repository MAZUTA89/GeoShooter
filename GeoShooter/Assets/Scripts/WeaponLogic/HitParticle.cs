using System;
using System.Collections.Generic;
using UnityEngine;

namespace WeaponLogic
{
    public class HitParticle : MonoBehaviour
    {
        [SerializeField] private float _deathTime;

        float _currentTime;

        private void Update()
        {
            _currentTime += Time.deltaTime;

            if(_currentTime >= _deathTime)
            {
                Destroy(gameObject);
            }
        }
    }
}
