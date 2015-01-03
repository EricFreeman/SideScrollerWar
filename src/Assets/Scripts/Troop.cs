using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public class Troop : MonoBehaviour
    {
        public List<Sprite> IdleAnimations;
        public List<Sprite> WalkAnimations;
        public List<Sprite> AttackAnimations;
        public List<Sprite> DeathAnimations;

        public float Speed = 1f;
        public int AttackDelay = 1000;

        public int Health = 10;
        public int Attack = 1;

        public bool IsPlayer;

        void Update()
        {
            transform.Translate(Speed * Time.deltaTime * (IsPlayer ? 1 : -1), 0, 0);
        }
    }
}