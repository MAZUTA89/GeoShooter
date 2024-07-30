using System;
using System.Collections.Generic;
using UnityEngine;

namespace GameSO
{
    [CreateAssetMenu(fileName = "EnemySO", menuName = "SO/Enemy")]
    public class EnemySO : ScriptableObject
    {
        public int Health;
        public float Speed;
        public float Force;
    }
}
