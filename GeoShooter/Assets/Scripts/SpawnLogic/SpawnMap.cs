using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.SpawnLogic
{
    public class SpawnMap : MonoBehaviour
    {
        [SerializeField] private Transform _startPoint;
        [SerializeField] private Transform _endPoint;
        [SerializeField] private float _stepOffset;

        List<Vector3> _spawnPoints;
        private void Start()
        {
            _spawnPoints = new List<Vector3>();
            InitializeSpawnPoints();
        }


        void InitializeSpawnPoints()
        {
            for (float z = _startPoint.position.x;
                z < _endPoint.position.z; z+= _stepOffset)
            {
                for (float x = _startPoint.position.x;
                    x < _endPoint.position.x; x+= _stepOffset)
                {
                    Vector3 point = new Vector3(x, _startPoint.position.y, z);
                    _spawnPoints.Add(point);
                }
            }
        }
    }
}
