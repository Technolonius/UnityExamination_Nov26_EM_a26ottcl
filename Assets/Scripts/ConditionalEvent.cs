using UnityEngine;
using UnityEngine.Events;
public class ConditionalEvent : MonoBehaviour
{ 
    public UnityEvent conditionEvent;
    public int counter;
    private int internalCounter;

    public void AddCounter(int value)
    {
        internalCounter += value;

        if (internalCounter >= counter)
        {
            conditionEvent.Invoke();
        }
    }
}
