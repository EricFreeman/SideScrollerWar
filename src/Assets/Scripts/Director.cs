using Assets.Scripts.Messages;
using Assets.Scripts.Models;
using Assets.Scripts.Util;
using UnityEngine;
using UnityEventAggregator;

namespace Assets.Scripts
{
    public class Director : MonoBehaviour
    {
        void Update()
        {
            GameContext.Money += GameContext.MoneyRate;
            EventAggregator.SendMessage(new UpdateUiMessage());
        }

        public void Buy(string troopType)
        {
            var troop = ((GameObject)Instantiate(Resources.Load<GameObject>("Prefabs/{0}".ToFormat(troopType)))).GetComponent<Troop>();
            if (GameContext.Money >= troop.Cost)
            {
                troop.IsPlayer = true;

                var y = Random.Range(0f, .7f);
                troop.transform.Translate(1, y, 0);

                troop.SpriteRenderer.sortingOrder = 70 - (int)(y * 100f);
                GameContext.Money -= troop.Cost;
            }
            else
            {
                Destroy(troop.gameObject);
            }
        }
    }
}