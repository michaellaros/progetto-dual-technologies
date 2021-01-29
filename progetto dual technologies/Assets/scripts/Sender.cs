using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sender : MonoBehaviour
{
    public OSC MyOsc;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SenderSyncFreeze()
    {
        OscMessage tempMessageToSend = new OscMessage();
        tempMessageToSend.address = "/SyncAilmentFreeze";
        tempMessageToSend.values.Add(1);

        MyOsc.Send(tempMessageToSend);
    }

    public void SenderSyncFog()
    {
        OscMessage tempMessageToSend = new OscMessage();
        tempMessageToSend.address = "/SyncAilmentFog";
        tempMessageToSend.values.Add(1);

        MyOsc.Send(tempMessageToSend);
    }
}
