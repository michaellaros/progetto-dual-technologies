using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sender : MonoBehaviour
{
    public OSC MyOsc;

    private int Freeze = 1;
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
        tempMessageToSend.address = "/SyncAilment";
        tempMessageToSend.values.Add(Freeze);

        MyOsc.Send(tempMessageToSend);
    }
}
