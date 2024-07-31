using InputCode;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace PlayerCode
{
    public class PlayerMovement
    {
        const float c_gravity = 1.8f;
        const float c_speed = 10f;
        CharacterController _controller;
        Transform _cameraTransform;
        InputService _inputService;
        Animator _animator;
        int _horizontalCode;
        int _verticalCode;
        public PlayerMovement(CharacterController characterController,
            Transform cameraTransform,
            InputService inputService,
            Animator animator)
        {
            _controller = characterController;
            _cameraTransform = cameraTransform;
            _inputService = inputService;
            _animator = animator;
            _horizontalCode = Animator.StringToHash("Horizontal");
            _verticalCode = Animator.StringToHash("Vertical");
        }

        public void Update(float ticks)
        {
            Vector2 input = _inputService.GetMovement();

            _animator.SetFloat(_horizontalCode, input.x);
            _animator.SetFloat(_verticalCode, input.y);

            Vector3 movement = _cameraTransform.right * input.x +
                _cameraTransform.up * input.y;

            movement.y = -c_gravity;

            movement *= ticks * c_speed;

            _controller.Move(movement);
        }
    }
}
