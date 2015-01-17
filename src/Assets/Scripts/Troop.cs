using System.Collections.Generic;
using Assets.Scripts.Models;
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

        public float Cost = 100;

        public bool IsPlayer;

        public SpriteRenderer SpriteRenderer;

        void Update()
        {
            if (CanMove())
                MoveTroop();
        }

        private void MoveTroop()
        {
            transform.Translate(Speed * Time.deltaTime * (IsPlayer ? 1 : -1), 0, 0);
        }

        private bool CanMove()
        {
            var isWithinLevel = (IsPlayer && transform.position.x < GameContext.LevelSize - GameContext.BaseSize) || (!IsPlayer && transform.position.x > GameContext.BaseSize);

            return isWithinLevel;
        }
    }
}