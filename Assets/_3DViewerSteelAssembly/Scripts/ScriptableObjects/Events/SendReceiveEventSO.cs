using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "Events/SendReceiveEvent", fileName = "SendReceiveEventSO")]
public class SendReceiveEventSO : ScriptableObject
{
    public UnityAction OnEventRaised;

    public void RaiseEvent()
    {
        if (OnEventRaised != null)
        {
            OnEventRaised.Invoke();
        }

    }
}

