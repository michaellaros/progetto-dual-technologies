using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InputManager : MonoBehaviour
{
    public static InputManager Singleton;

    [Header("Arduino Parameters:")]
    public Arduino arduino;
    public int ButtonPin = 6;
    public int SoundPin = 2;
    public float SoundNormalizedValue;
    public float SoundThreshold = 0.75f;

    [Header("Input Events:")]
    public UnityEvent LDownEvent;
    public UnityEvent LUpEvent;

    public UnityEvent RDownEvent;
    public UnityEvent RUpEvent;

    [Header("Input States:")]
    public bool ArduinoConnected;
    private bool LPressed;
    private bool RPressed;

    private void OnEnable() 
    {
        if(Singleton != null)
        {
            Destroy(Singleton);
        }
        else
        {
            Singleton = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        arduino.Setup(ConfigurePins);
    }

    void ConfigurePins()
		{
			arduino.pinMode(SoundPin, PinMode.ANALOG);
			arduino.reportAnalog(SoundPin, 1);

            arduino.pinMode(ButtonPin, PinMode.INPUT);
			arduino.reportDigital((byte)(ButtonPin/8), 1);
		}

    // Update is called once per frame
    void Update()
    {
        LInputs();
        RInputs();
    }

    void LInputs()
    {
        if( arduino.digitalRead(ButtonPin) > 0.5f)
            {
                if(!LPressed)
                {
                 LDownEvent.Invoke();
                 LPressed = true;
                }
            
            }
            else
            {
                if(LPressed)
                {
                 LUpEvent.Invoke();
                 LPressed = false;
                }
            }
        if (Input.GetButtonDown("Fire1"))
        {
            LDownEvent.Invoke();
            LPressed = true;
        }
        if (Input.GetButtonUp("Fire1"))
        {
            LUpEvent.Invoke();
            LPressed = false;
        }
    }

    void RInputs()
    {
        SoundNormalizedValue = (float)arduino.analogRead(SoundPin) / 1024f;
        print(arduino.analogRead(0));
        if (SoundNormalizedValue > SoundThreshold)
        {
            if (!RPressed)
            {
                RDownEvent.Invoke();
                RPressed = true;
            }

        }
        else
        {
            if (RPressed)
            {
                RUpEvent.Invoke();
                RPressed = true;
            }
        }
        if (Input.GetButtonDown("Fire2"))
        {
            RDownEvent.Invoke();
            RPressed = true;
        }
        if (Input.GetButtonUp("Fire2"))
        {
            RUpEvent.Invoke();
            RPressed = false;
        }

    }
}
