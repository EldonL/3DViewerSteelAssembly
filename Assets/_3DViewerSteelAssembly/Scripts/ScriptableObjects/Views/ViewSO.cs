using UnityEngine;

using System.Collections.Generic;
using ThreeDViewerSteelAssembly.UIs.Menus.Views;
[CreateAssetMenu(menuName = "View/ViewSO", fileName = "ViewSO")]
public class ViewSO : ScriptableObject
{
    [SerializeField] private List<View> views;
    public List<View> Views => views; 
}
