using Assets.Scripts.Models;
using Assets.Scripts.Util;
using UnityEngine;

namespace Assets.Scripts
{
    public class CameraMovement : MonoBehaviour
    {
        private Vector3? _oldMousePosition;
        private float _velocity;

        void Update()
        {
            _velocity = _velocity.MoveTowards(0, 2f);
            if (_velocity > 50) _velocity = 50;
            transform.Translate(_velocity / 50, 0, 0);
            if (transform.position.x < 0) transform.position = new Vector3(0, transform.position.y, transform.position.z);
            if (transform.position.x > GameContext.LevelSize) transform.position = new Vector3(GameContext.LevelSize, transform.position.y, transform.position.z);

            if (Input.GetMouseButton(0))
            {
                if (!_oldMousePosition.HasValue) _oldMousePosition = Input.mousePosition;
                _velocity -= (Input.mousePosition - _oldMousePosition.Value).x;
                _oldMousePosition = Input.mousePosition;
            }
            else
                _oldMousePosition = null;
        }
    }
}