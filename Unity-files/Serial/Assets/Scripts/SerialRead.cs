using UnityEngine;
using System.Collections;

public class SerialRead : MonoBehaviour {

    SerialPort stream = new SerialPort("COM3", 9800); //Set the port (com4) and the baud rate (9600, is standard on most devices)
    float[] lastRot = { 0, 0, 0 }; //Need the last rotation to tell how far to spin the camera
    Vector3 rot;
    Vector3 offset;


    void Start()
    {
        stream.Open(); //Open the Serial Stream.
    }

    // Update is called once per frame
    void Update()
    {
        string value = stream.ReadLine(); //Read the information
        string[] vec3 = value.Split(','); //My arduino script returns a 3 part value (IE: 12,30,18)
        if (vec3[0] != "" && vec3[1] != "" && vec3[2] != "") //Check if all values are recieved
        {
            rot = new Vector3(float.Parse(vec3[0]), float.Parse(vec3[1]), float.Parse(vec3[2]));
            //Read the information and put it in a vector3
            transform.rotation = Quaternion.Slerp(transform.rotation,
                                                                        Quaternion.Euler(0, rot.x, rot.y),
                                                                        Time.deltaTime * 3);
            //Take the vector3 and apply it to the object this script is applied.
            stream.BaseStream.Flush(); //Clear the serial information so we assure we get new information.
        }
    }

    void OnGUI()
    {
        string newString = "Connected: " + transform.eulerAngles;
        GUI.Label(new Rect(10, 10, 300, 100), newString); //Display new values
        GUI.Label(new Rect(10, 30, 300, 100), "\t" + rot);
    }
}
