using UnityEngine;
using System.Collections;
using System.IO.Ports;
using System.Threading;

public class SerialWork : MonoBehaviour {
    public static string portStr = "COM3";
    public SerialPort serial = new SerialPort(portStr, 9600);
    //	Debug.Log("Initalized serial port");


    //public GameObject light = null;
    public AudioClip clip;
    


    void Start()
    {
        serial.Open();
        Debug.Log("Testing");

        OpenCheck();
    }

    void OpenCheck()
    {
        if (serial.IsOpen == false)
        {
            //serial.Write ("Force Open");
            Debug.Log("Force Open");
            serial.Open();
        }
        else
        {
            //serial.Write ("Port already opened");
            Debug.Log("Port already opened");
        }
    }

    public void ActivateSerial()
    {
        Debug.Log("Serial called");

        OpenCheck();
        
        serial.Write("1");
        Debug.Log("Serial sent to Arduino");

    }

    void Update()
    {
        ActivateSerial();
    }

}
