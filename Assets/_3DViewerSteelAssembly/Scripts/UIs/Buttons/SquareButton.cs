using System;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ThreeDViewerSteelAssembly.UIs.Buttons
{
    public class SquareButton : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _buttonName;
        [SerializeField] private Image _buttonImage;
        [SerializeField] private Button _buttonElement;
        private SendReceiveEventSO _onButtonClickAction;



        internal void Init(string buttonName, Sprite buttonImage, SendReceiveEventSO onButtonClickAction)
        {
            _buttonName.text = buttonName;
            _buttonImage.sprite = buttonImage;
            _onButtonClickAction = onButtonClickAction;
            _buttonElement.onClick.AddListener(_onButtonClickAction.RaiseEvent);
        }

        private void OnDestroy()
        {
            _buttonElement.onClick.RemoveAllListeners();
        }
    }

}