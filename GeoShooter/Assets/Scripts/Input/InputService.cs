using System;
using UnityEngine;

namespace InputCode
{
    public class InputService : IDisposable
    {
        GameControls _gameControls;
        public InputService()
        {
            _gameControls = new GameControls();
            _gameControls.Enable();
        }

        public Vector2 GetMovement()
        {
            return _gameControls.MovementActions.Movement.ReadValue<Vector2>();
        }
        public bool IsShoot()
        {
            return _gameControls.ShootActions.Shoot.IsPressed();
        }

        public void Dispose()
        {
            _gameControls.Disable();
            _gameControls.Dispose();
        }
    }
}
