using InputCode;
using System;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace PlayerCode
{
    [RequireComponent(typeof(CharacterController))]
    public class Player : MonoBehaviour
    {
        InputService _inputService;
        PlayerMovement _playerMovement;
        PlayerRotation _playerRotation;
        CharacterController _characterController;
        Camera _camera;
        Vector3 _mousePosition;
        public Vector3 MouseWorldPosition => _mousePosition;
        [Inject]
        public void Constructor(InputService inputService)
        {
            _inputService = inputService;
        }

        private void Start()
        {
            _camera = Camera.main;
            _characterController = GetComponent<CharacterController>();
            _playerMovement = new PlayerMovement(_characterController,
                _camera.transform, _inputService);

            _playerRotation = new PlayerRotation(this);
        }

        private void Update()
        {
            _mousePosition = GetMousePisition();

            _playerMovement.Update(Time.deltaTime);

            _playerRotation.Update(Time.deltaTime);
        }

        Vector3 GetMousePisition()
        {
            Vector3 mousePosition = Input.mousePosition;

            Plane plane = new Plane(Vector3.up, transform.position);

            Ray ray = _camera.ScreenPointToRay(mousePosition);
            if (plane.Raycast(ray, out float dist))
            {
                return ray.GetPoint(dist);
            }
            else
            {
                return Vector3.zero;
            }
        }
    }
}
