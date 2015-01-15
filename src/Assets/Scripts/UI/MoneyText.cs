using Assets.Scripts.Messages;
using Assets.Scripts.Models;
using UnityEngine;
using UnityEngine.UI;
using UnityEventAggregator;

namespace Assets.Scripts.UI
{
    public class MoneyText : MonoBehaviour,
        IListener<UpdateUiMessage>
    {
        void Start()
        {
            this.Register<UpdateUiMessage>();
        }

        void OnDestroy()
        {
            this.UnRegister<UpdateUiMessage>();
        }

        public void Handle(UpdateUiMessage message)
        {
            GetComponent<Text>().text = GameContext.Money.ToString("C");
        }
    }
}