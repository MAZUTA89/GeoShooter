using System;
using System.Collections.Generic;
using UnityEngine;

namespace GameSO
{
    [CreateAssetMenu(fileName = "Spawn", menuName = "SO/Spawn")]
    public class SpawnSO : ScriptableObject
    {
        public float SpawnDelay;
        public float SpawnMinDelay;
        public float SpawnDelayMultiplier;
    }
}
