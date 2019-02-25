using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.EventSystems;

namespace Framework.UI
{
    [AddComponentMenu("Helper/UI/ToggleAssist")]
    [RequireComponent(typeof(Image))]
    public class UIToggleAssist : UIToggle
    {
        public GameObject[] ValueTrue;
        public GameObject[] ValueFalse;
        protected override void ValueChanged_Game(bool varIsOn)
        {
            base.ValueChanged_Game(varIsOn);
            for (int i = 0; i < ValueTrue.Length; i++)
            {
                ValueTrue[i].SetActive(varIsOn);
            }
            for (int i = 0; i < ValueFalse.Length; i++)
            {
                ValueFalse[i].SetActive(!varIsOn);
            }
        }
    }
}