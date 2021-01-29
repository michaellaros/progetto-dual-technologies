using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Recever : MonoBehaviour
{
    public static Recever Singleton;

    public OSC MyOsc;
    private int Freeze = 0;
    private int Fog = 0;

    [Header("Ailment Events:")]
    public UnityEvent FreezeEvent;
    public UnityEvent FogEvent;

    // Start is called before the first frame update
    void Start()
    {
        MyOsc.SetAddressHandler("/SyncAilmentFreeze",ReceveSyncFreeze);
        MyOsc.SetAddressHandler("/SyncAilmentFog",ReceveSyncFog);
    }

    // Update is called once per frame
    void Update()
    {
        if(Freeze == 1)
        {
            FreezeEvent.Invoke();
            Freeze = 0;
        }
        if(Fog == 1)
        {
            FogEvent.Invoke();
            Fog = 0;
        }
    }

    void ReceveSyncFreeze(OscMessage inputMessage)
    {
        Freeze = (inputMessage.GetInt(0));
    }

    void ReceveSyncFog(OscMessage inputMessage)
    {
        Fog = (inputMessage.GetInt(0));
    }
}
