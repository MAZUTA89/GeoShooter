using GameSO;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace SpawnLogic
{
    public class EnemySpawner : MonoBehaviour
    {
        List<Transform> _spawnPoints;
        SpawnSO _spawnSO;
        float _currentTime;
        float _currentSpawnDelay;
        float SpawnDelay
        {
            get
            {
                return _currentSpawnDelay;
            }
            set
            {
                _currentSpawnDelay = value;
                if(_currentSpawnDelay < _spawnSO.SpawnMinDelay)
                    _currentSpawnDelay = _spawnSO.SpawnMinDelay;
            }
        }
        EnemyFactory _enemyFactory;
        [Inject] 
        public void Construct(List<Transform> spawnPoints,
            SpawnSO spawnSO, EnemyFactory factory)
        {
            _spawnPoints = spawnPoints;
            _spawnSO = spawnSO;
            _enemyFactory = factory;
        }

        private void Start()
        {
            _currentTime = 0f;
            SpawnDelay = _spawnSO.SpawnDelay;
        }

        public void Update()
        {
            _currentTime += Time.deltaTime;
            
            if(_currentTime >= SpawnDelay)
            {
                _currentTime = 0;

                Transform point = GetRandomSpawnPoint();

                _enemyFactory.Create(point);

                SpawnDelay -= _spawnSO.SpawnDelayMultiplier;
            }
        }

        Transform GetRandomSpawnPoint()
        {
            int randomIndex = Random.Range(0, _spawnPoints.Count);
            return _spawnPoints[randomIndex];
        }
    }
}
