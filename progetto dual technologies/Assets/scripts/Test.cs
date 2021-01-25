using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class Test : MonoBehaviour
{
    public UnityEvent action;
    public UnityEvent actionUscita;
    public string TriggerTag;

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(TriggerTag))
        {
            if (action != null)action.Invoke();   
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag(TriggerTag))
        {
            if (action != null)actionUscita.Invoke();
        }
        
    }



}
