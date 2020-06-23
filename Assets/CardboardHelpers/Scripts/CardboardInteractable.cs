using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CardboardInteractable : MonoBehaviour
{
    public UnityEvent onHoverEnter = new UnityEvent();
    public UnityEvent onHoverExit = new UnityEvent();
    public UnityEvent onSelectEnter = new UnityEvent();
    public UnityEvent onSelectExit = new UnityEvent();

    private bool _isHovering;
    private bool _isSelecting;

    public void PointerEnter()
    {
        _isHovering = true;
        onHoverEnter.Invoke();
    }

    public void PointerExit()
    {
        _isHovering = false;
        onHoverExit.Invoke();
    }

    private void Update()
    {
        if (XRCardboardController.Instance.IsTriggerPressed())
        {
            if (_isSelecting)
            {
                _isSelecting = false;
                onSelectExit.Invoke();
            }
            else if (_isHovering)
            {
                _isSelecting = true;
                onSelectEnter.Invoke();
            }
        }
    }
}
