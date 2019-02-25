using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.Events;

namespace Framework.UI
{
    [AddComponentMenu("Helper/UI/Button")]
    [RequireComponent(typeof(Image))]
    public class UIButton : Button
    {
        public ClickGame onClickGame = new ClickGame();

        public override void OnPointerClick(PointerEventData eventData)
        {
            base.OnPointerClick(eventData);
            onClickGame.Invoke(this.gameObject);
        }
        //public override void OnPointerDown(PointerEventData eventData)
        //{
        //    base.OnPointerDown(eventData);
        //}
        public class ClickGame : UnityEvent<GameObject>
        {
        }
    }
}