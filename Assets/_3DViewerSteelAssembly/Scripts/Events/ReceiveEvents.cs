using UnityEngine;
using UnityEngine.Events;

public class ReceiveEvents : MonoBehaviour
{
    [SerializeField] private SendReceiveEventSO sendReceiveEventSO;
    [SerializeField] private UnityEvent response;

    private void OnEnable()
    {
        sendReceiveEventSO.OnEventRaised += OnEventRaised;
    }

    private void OnDisable()
    {
        sendReceiveEventSO.OnEventRaised -= OnEventRaised;
    }

    private void OnEventRaised()
    {
        response?.Invoke();
    }
}
