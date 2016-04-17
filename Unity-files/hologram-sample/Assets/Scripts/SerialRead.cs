using UnityEngine;
using System.Collections;
using System.IO.Ports;

public class SerialRead : MonoBehaviour {

    int counter = 0;
    SerialPort stream = new SerialPort("COM3", 9800); //Set the port (com4) and the baud rate (9600, is standard on most devices)
    public string command;

    void Start()
    {
        stream.Open(); //Open the Serial Stream.
    }

    // Update is called once per frame
    void Update()
    {
        command = stream.ReadLine(); //Read the information
        Debug.Log(counter);
        counter++;
    }

}
