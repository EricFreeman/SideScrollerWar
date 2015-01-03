using Assets.Scripts.Util;
using UnityEngine;

namespace Assets.Scripts
{
    public class Director : MonoBehaviour
    {
        public void Buy(string troopType)
        {
            var troop = ((GameObject)Instantiate(Resources.Load<GameObject>("Prefabs/{0}".ToFormat(troopType)))).GetComponent<Troop>();
            troop.IsPlayer = true;

            var y = Random.Range(0f, .7f);
            troop.transform.Translate(1, y, 0);

            troop.SpriteRenderer.sortingOrder = 70 - (int)(y * 100f);

        }
    }
}