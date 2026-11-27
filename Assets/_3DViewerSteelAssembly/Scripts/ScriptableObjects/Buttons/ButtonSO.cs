using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "Button/ButtonSO", fileName = "ButtonSO")]
public class ButtonSO : ScriptableObject
{
    [SerializeField] private string _buttonName;
    public string ButtonName { get => _buttonName; }
    [SerializeField] private Sprite _buttonSprite; 
    public Sprite ButtonSprite { get => _buttonSprite; }

    [SerializeField] private SendReceiveEventSO _onButtonClickAction;
    public SendReceiveEventSO OnButtonClickAction => _onButtonClickAction;

}
