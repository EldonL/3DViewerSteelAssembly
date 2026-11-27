using ThreeDViewerSteelAssembly.UIs.Menus.Views;
namespace ThreeDViewerSteelAssembly.SceneControllers
{

    public class MainSceneController : GameSceneController
    {
        private ConfirmView _confirmView;
        private MainView _mainView;
        protected override void Start()
        {
            base.Start();
            _mainView = ShowView(ViewType.mainView) as MainView;
            _mainView.HideMeasureBar();

        }

        public void OnOpenConfirmView()
        {
            _confirmView = ShowView(ViewType.confirmView, null, "Mock UI", "No need to implement as mentioned Unity Developer Technical Test", "Cancel") as ConfirmView;
            _mainView.HideMeasureBar();
           
        }

        public void OnOpenMeasureTool()
        {
            if(_confirmView !=null)
            {
                _confirmView.Back();
            }
            _mainView.ShowMeasureBar();
        }
    }

}