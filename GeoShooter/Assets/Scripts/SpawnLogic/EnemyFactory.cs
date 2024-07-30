using Enemies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Zenject;

namespace SpawnLogic
{
    public class EnemyFactory
    {
        Enemy _enemyTemplate;
        IInstantiator _instantiator;
        public EnemyFactory(Enemy enemyTemplate, IInstantiator instantiator)
        {
            _enemyTemplate = enemyTemplate;
            _instantiator = instantiator;
        }
        public Enemy Create(Transform point)
        {
            var enemy = _instantiator.InstantiatePrefabForComponent<Enemy>(
                _enemyTemplate, point.position,
                point.rotation, null);

            return enemy;
        }
    }
}
