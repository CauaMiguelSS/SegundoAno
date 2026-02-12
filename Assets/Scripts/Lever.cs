using UnityEngine;
using UnityEngine.Events;

public class Lever : MonoBehaviour, IInteractable
{
    [SerializeField] private bool _once;
    [SerializeField] private bool _isActive;
    [SerializeField] private UnityEvent OnActive;
    [SerializeField] private UnityEvent OnSDesactive;
    public void Active()
    {
        OnActive.Invoke();
        if (!_once)
            return;

        Destroy(this);
    }
}
