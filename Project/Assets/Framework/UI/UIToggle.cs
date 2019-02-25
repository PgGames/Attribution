using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Framework.UI
{
    [AddComponentMenu("Helper/UI/Toggle")]
    public class UIToggle : Toggle
    {
        public ValueChanged onValueChangedGame = new ValueChanged();

        protected override void Awake()
        {
            base.Awake();
        }
        public override void OnPointerClick(PointerEventData eventData)
        {
            base.OnPointerClick(eventData);
            ValueChanged_Game(isOn);
        }
        protected virtual void ValueChanged_Game(bool varIsOn)
        {
            onValueChangedGame.Invoke(this.gameObject, varIsOn);
        }

        public class ValueChanged : UnityEvent<GameObject, bool>
        {
        }
    }
}