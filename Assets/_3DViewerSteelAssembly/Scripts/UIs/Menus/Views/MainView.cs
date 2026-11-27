
using ThreeDViewerSteelAssembly.UIs.Elements;
using UnityEngine;

namespace ThreeDViewerSteelAssembly.UIs.Menus.Views
{
    public class MainView : View
    {
        [SerializeField] private MeasureBar _measureBar;

        internal void ShowMeasureBar()
        {
            _measureBar.gameObject.SetActive(true);
        }
        
        internal void HideMeasureBar()
        {
            _measureBar.gameObject.SetActive(false);
        }
        

    }

}