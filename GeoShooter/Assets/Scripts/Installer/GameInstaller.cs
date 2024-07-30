using PlayerCode;
using System;
using System.Collections.Generic;
using Zenject;
using UnityEngine;
using GameSO;
using InputCode;
using SpawnLogic;
using Enemies;
using WeaponLogic;

namespace Installer
{
    public class GameInstaller : MonoInstaller
    {
        [SerializeField] private List<Transform> _spawnPoints;
        [SerializeField] private SpawnSO _spawnSO;
        [SerializeField] private Enemy _enemyTemplate;
        [SerializeField] private WeaponSO _weaponSO;
        [SerializeField] private EnemySO _enemySO;

        public override void InstallBindings()
        {
            BindInputService();
            BindPlayer();
            BindSpawner();
            BindEnemy();
            BindWeapon();
        }

        void BindInputService()
        {
            Container.Bind<InputService>().AsSingle();
        }
        void BindPlayer()
        {
            Container.Bind<Player>().
                 FromComponentInHierarchy().
                 AsSingle();
        }

        void BindSpawner()
        {
            EnemyFactory enemyFactory = new EnemyFactory(_enemyTemplate,
                Container);
            Container.BindInstance(enemyFactory);
            Container.BindInstance(_spawnPoints);
            Container.BindInstance(_spawnSO);
            Container.Bind<EnemySpawner>()
                .FromComponentInHierarchy()
                .AsSingle();
        }
        void BindWeapon()
        {
            Container.BindInstance(_weaponSO);
            Container.Bind<Weapon>()
                .FromComponentInHierarchy()
                .AsSingle();
        }
        void BindEnemy()
        {
            EnemyHealth enemyHealth = new EnemyHealth(_enemySO);
            Container.BindInstance(enemyHealth);
            Container.Bind<Enemy>().AsTransient();
            Container.BindInstance(_enemySO);
        }
    }
}
