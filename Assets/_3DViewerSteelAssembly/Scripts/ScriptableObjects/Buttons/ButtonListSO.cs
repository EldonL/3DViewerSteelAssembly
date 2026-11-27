using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "Button/ButtonListSO", fileName = "ButtonListSO")]
public class ButtonListSO : ScriptableObject
{
    [SerializeField] private List<ButtonSO> buttonSOs;
    public List<ButtonSO> ButtonSOs { get => buttonSOs; }

}
