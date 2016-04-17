using UnityEngine;
using System.Collections;
using System.IO.Ports;

public class SerialRead : MonoBehaviour {


    SerialPort stream = new SerialPort("COM3", 9800); //Set the port (com4) and the baud rate (9600, is standard on most devices)


    void Start()
    {
        stream.Open(); //Open the Serial Stream.
    }

    // Update is called once per frame
    void Update()
    {
        string value = stream.ReadLine(); //Read the information
        Debug.Log("Message: " + value);
    }

    /*
    void OnGUI()
    {
        string newString = "Connected: " + transform.eulerAngles;
        GUI.Label(new Rect(10, 10, 300, 100), newString); //Display new values
        GUI.Label(new Rect(10, 30, 300, 100), "\t" + rot);
    }
    */
}
