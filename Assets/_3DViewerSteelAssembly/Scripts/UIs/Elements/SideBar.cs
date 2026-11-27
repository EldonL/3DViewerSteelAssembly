using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ThreeDViewerSteelAssembly.UIs.Buttons;

namespace ThreeDViewerSteelAssembly.UIs.Elements
{
    public abstract class SideBar : MonoBehaviour
    {
        [SerializeField] private Transform container;
        [SerializeField] private SquareButton _squareButtonPrefab;
        [SerializeField] private List<ButtonSO> ButtonSOs;



        protected virtual void Start()
        {
            Init();
        }
        internal void Init()
        {
            foreach (var b in ButtonSOs)
            {
                var result = Instantiate(_squareButtonPrefab, container);
                result.Init(b.ButtonName, b.ButtonSprite, b.OnButtonClickAction);
            }
        }
    }

}