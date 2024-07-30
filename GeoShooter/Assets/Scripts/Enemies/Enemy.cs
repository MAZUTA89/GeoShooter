using GameSO;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace Enemies
{
    public class Enemy : MonoBehaviour
    {
        [SerializeField] private Transform _rayOrigin;
        [SerializeField] private float _MaxHealth;
        [SerializeField] private float _force = 2f;
        EnemySO _enemySO;
        EnemyHealth _health;
        float _currentHealth;
        Rigidbody _rb;
        EnemyMovement _movement;

        [Inject]
        public void Construct(EnemyHealth enemyHealth,
            EnemySO enemySO)
        {
            _health = enemyHealth;
            _enemySO = enemySO;
        }
        private void Start()
        {
            _rb = GetComponent<Rigidbody>();
            _movement = new EnemyMovement(_rb, transform, _enemySO);
            _currentHealth = _MaxHealth;
            _force = _enemySO.Force;
        }

        public void Update()
        {
            if (IsChangeDirection())
            {
                ChangeDirection();
            }
        }

        private void FixedUpdate()
        {
            _movement.FixedUpdate(Time.fixedDeltaTime);

        }
        private void OnCollisionEnter(Collision collision)
        {
            if(collision.gameObject.CompareTag("Player") ||
                    collision.collider.gameObject.CompareTag("Enemy"))
            {
                _rb.AddForce(transform.forward.normalized * -1f * _force,
                    ForceMode.Impulse);
            }
        }
        bool IsChangeDirection()
        {
            Ray ray = new Ray(_rayOrigin.position,
                transform.forward);
            Debug.DrawRay(ray.origin, ray.direction);
            if (Physics.Raycast(ray, out RaycastHit hit, 2f))
            {
                if (hit.collider.gameObject.CompareTag("Player") ||
                    hit.collider.gameObject.CompareTag("Enemy"))
                    return false;
                else
                    return true;
            }
            else
            {
                return false;
            }
        }

        void ChangeDirection()
        {
            float randomAngle = Random.Range(-110, 110);
            transform.Rotate(0, randomAngle, 0);
        }

        public void TakeDamage(int damage)
        {
            _health.Helth -= damage;
            if(_health.IsDead)
            {
                Destroy(gameObject);
            }
        }
    }
}
