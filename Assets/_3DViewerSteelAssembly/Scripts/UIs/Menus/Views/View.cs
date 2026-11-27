using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace ThreeDViewerSteelAssembly.UIs.Menus.Views
{
    public class View : MonoBehaviour
    {
        [SerializeField] private ViewType _viewTypeEnum;
        [SerializeField] private ViewNavigation _viewNavigationEnum;
        internal event Action BackRequested;
        public ViewType ViewTypeEnum => _viewTypeEnum;
        public ViewNavigation ViewNavigationEnum => _viewNavigationEnum; 

        public bool IsShowing { get; internal set; }

        [SerializeField] protected GameObject _uiRoot;
        [SerializeField] protected TextMeshProUGUI _titleText; 
        [SerializeField] protected TextMeshProUGUI _messageText; 
        [SerializeField] protected TextMeshProUGUI _cancelText;
        internal Action _onCancel;
        private int _viewSpawnLocation; 
        public int ViewSpawnLocation { get => _viewSpawnLocation; set => _viewSpawnLocation = value; }
       
        protected virtual void Awake()
        {

        }

        protected virtual void Start()
        {

        }
        public virtual void Show()
        {
            _uiRoot.SetActive(true);
            IsShowing = true;
        }
        
        public virtual void Show(Action onCancel, string title, string message, string cancelText = "Cancel")
        {
            _titleText.text = title;
            _messageText.text = message;
            _cancelText.text = cancelText;
            _onCancel = onCancel;
            Show();
        }

        public virtual void Hide()
        {
            _uiRoot.SetActive(false);
            IsShowing = false;
        }

        public virtual void Back()
        {
            BackRequested?.Invoke();
        }
    }
}
