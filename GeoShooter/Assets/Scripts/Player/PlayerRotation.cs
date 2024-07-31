using System;
using System.Collections.Generic;
using UnityEngine;

namespace PlayerCode
{
    public class PlayerRotation
    {
        const float c_rotetionSpeed = 200f;
        Player _player;
        public PlayerRotation(Player player)
        {
            _player = player;
        }

        public void Update(float ticks)
        {
            Vector3 mousePos = _player.MouseWorldPosition;

            Vector3 direction = mousePos - _player.transform.position;
            direction = new Vector3(direction.x, 0, direction.z);
            Quaternion targetRotation = Quaternion.LookRotation(direction);

            _player.transform.rotation = Quaternion.RotateTowards(_player.transform.rotation,
                targetRotation, ticks * c_rotetionSpeed);
        }
    }
}
