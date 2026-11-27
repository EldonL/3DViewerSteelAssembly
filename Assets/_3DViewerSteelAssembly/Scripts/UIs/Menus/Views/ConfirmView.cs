using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ThreeDViewerSteelAssembly.UIs.Menus.Views
{
    public class ConfirmView : View
    {
        public void Cancel()
        {
            _onCancel?.Invoke();
            Back();
        }
    }

}