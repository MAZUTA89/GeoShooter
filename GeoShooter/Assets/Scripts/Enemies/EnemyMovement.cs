using GameSO;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Enemies
{
    public class EnemyMovement
    {
        Rigidbody _rb;
        Transform _transform;
        float _speed = 2f;
        public EnemyMovement(Rigidbody rigidbody, Transform transform,
            EnemySO enemySO)
        {
            _rb = rigidbody;
            _transform = transform;
            _speed = enemySO.Speed;
        }

        public void FixedUpdate(float fixedTicks)
        {
            _rb.MovePosition(_rb.position + _transform.forward.normalized
                * _speed * Time.fixedDeltaTime);
        }
    }
}
