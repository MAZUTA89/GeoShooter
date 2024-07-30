using System;
using System.Collections.Generic;
using UnityEngine;

namespace GameSO
{
    [CreateAssetMenu(fileName = "Weapon", menuName = "SO/Weapon")]
    public class WeaponSO : ScriptableObject
    {
        public float Speed;
        public int Damage;
    }
}
