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
            ShowView(ViewType.confirmView, null, "Not implemented", "No need to implement as mentioned in requirements", "Cancel");
        }

        public void OnOpenMeasureTool()
        {
            ShowView(ViewType.toolsView);
        }
    }

}