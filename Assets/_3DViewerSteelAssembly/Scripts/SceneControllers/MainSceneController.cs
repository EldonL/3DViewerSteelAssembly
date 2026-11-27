using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ThreeDViewerSteelAssembly.SceneControllers
{

    public class MainSceneController : GameSceneController
    {
        protected override void Start()
        {
            base.Start();
            ShowView(ViewType.mainView);
        }

        public void OnOpenConfirmView()
        {
            ShowView(ViewType.confirmView, null, "Mock UI", "No need to implement as mentioned Unity Developer Technical Test", "Cancel");
        }

        public void OnOpenMeasureTool()
        {
            ShowView(ViewType.toolsView);
        }
    }

}