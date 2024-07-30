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
        Animator _animator;
        EnemySO _enemySO;
        EnemyHealth _health;
        float _currentHealth;
        Rigidbody _rb;
        EnemyMovement _movement;

        int _deadTriggerCode;

        [Inject]
        public void Construct(
            EnemySO enemySO)
        {
            _enemySO = enemySO;
        }
        private void Start()
        {
            _rb = GetComponent<Rigidbody>();
            _movement = new EnemyMovement(_rb, transform, _enemySO);
            _currentHealth = _MaxHealth;
            _force = _enemySO.Force;
            _health = new EnemyHealth(_enemySO);
            _animator = GetComponent<Animator>();
            _deadTriggerCode = Animator.StringToHash("DeadTrigger");
        }

        public void Update()
        {
            if (IsChangeDirection() && 
                !_health.IsDead)
            {
                ChangeDirection();
            }
        }

        private void FixedUpdate()
        {
            if(!_health.IsDead)
            {
                _movement.FixedUpdate(Time.fixedDeltaTime);
            }

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

                _animator.SetTrigger(_deadTriggerCode);
            }
        }

        public void OnDeathEnd()
        {
            Destroy(gameObject);
        }
    }
}
