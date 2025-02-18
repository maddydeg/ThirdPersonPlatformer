using System;
using UnityEngine;

using UnityEngine.Events;

public class InputManager : MonoBehaviour
{
    public UnityEvent onSpacePressed = new UnityEvent();
    public UnityEvent onAPressed = new UnityEvent();
    public UnityEvent onDPress = new UnityEvent();
    public UnityEvent onWPress = new UnityEvent();
    public UnityEvent onSPress = new UnityEvent();
    void Update()
    {
        
    }
}
