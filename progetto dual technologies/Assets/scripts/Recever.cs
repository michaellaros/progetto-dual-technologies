using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Recever : MonoBehaviour
{
    public static Recever Singleton;

    public OSC MyOsc;
    private int Freeze = 0;

    [Header("Ailment Events:")]
    public UnityEvent FreezeEvent;

    // Start is called before the first frame update
    void Start()
    {
        MyOsc.SetAddressHandler("/SyncAilment",ReceveSyncFreeze);
    }

    // Update is called once per frame
    void Update()
    {
        if(Freeze == 1)
        {
            FreezeEvent.Invoke();
            Freeze = 0;
        }
    }

    void ReceveSyncFreeze(OscMessage inputMessage)
    {
        Freeze = (inputMessage.GetInt(0));
    }
}
