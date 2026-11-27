using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using ThreeDViewerSteelAssembly.UIs.Menus.Views;
using UnityEngine;

namespace ThreeDViewerSteelAssembly.SceneControllers
{
    public class GameSceneController : MonoBehaviour
    {
        [SerializeField] private Transform[] viewSpawnPoint;
        [SerializeField] private ViewSO Views;
        private Stack<View> ViewStack = new Stack<View>();

        private List<View> SpawnedViews = new List<View>();

   
        protected virtual void Awake()
        {
            
        }
        protected virtual void Start()
        {
            
        }

        protected virtual void OnDestroy()
        {

        }

        protected virtual void Init()
        {
        }


        internal View ShowView(ViewType viewType, int spawnLocation = 0)
        {
            View viewFound = SpawnedViews.FirstOrDefault(sv => sv.ViewTypeEnum == viewType);
            if (viewFound == null)
            {
                viewFound = SpawnView(viewType, spawnLocation);
            }
            if (viewFound.ViewNavigationEnum != ViewNavigation.permanant)
            {
                if (ViewStack.Count() > 0)
                {
                    ViewStack.Peek().Hide();
                    if(ViewStack.Peek() is ConfirmView)
                    {
                        ViewStack.Pop();
                    }
                }
                ViewStack.Push(viewFound);

            }

            viewFound.Show();
            return viewFound;
        }

        internal View ShowView(ViewType viewType, Action onCancel, string title, string message, string cancelText, int spawnLocation = 0)
        {
            View viewFound = ShowView(viewType, spawnLocation);

   
            viewFound.Show( onCancel, title, message, cancelText);
            return viewFound;
        }



        internal void CloseTopView()
        {
            if (ViewStack.Count == 0)
                return;

            View top = ViewStack.Pop();
            top.Hide();

            if (ViewStack.Count > 0)
            {
                ViewStack.Peek().Show();
            }

        }

        private View SpawnView(ViewType viewType, int spawnLocation = 0)
        {
            View viewFound = Views.Views.FirstOrDefault(v => v.ViewTypeEnum == viewType);
            if (viewFound == null)
            {
                Debug.LogError($"{viewType} not found");
                return null;
            }
            View SpawnView = Instantiate(viewFound, viewSpawnPoint[spawnLocation].transform.position, viewSpawnPoint[spawnLocation].transform.rotation, viewSpawnPoint[spawnLocation]);
            SpawnView.BackRequested += CloseTopView;
            SpawnedViews.Add(SpawnView);
            SpawnView.ViewSpawnLocation = spawnLocation;
            return SpawnView;
        }


    
    }
}
