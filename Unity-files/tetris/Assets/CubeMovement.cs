﻿using UnityEngine;
using System.Collections;

    
    public class CubeMovement : MonoBehaviour
    {

        public float moveSpeed;
        private float maxSpeed = 5f;
        private Vector3 input;
        SerialRead serial_script;
        public string command;

        int counter = 0;
  

        void serial2Output()
        {
        if (command == "U") {
            input = new Vector3(0, -1, 5);
        } else if (command == "D") {
            input = new Vector3(0, -1, -5);
        } else if (command == "L") {
            input = new Vector3(-5, -1, 0);
        } else if (command == "R") {
            input = new Vector3(5, -1, 0);
        } else if (command == "RTL") {
            transform.Rotate(0, 90, 0);
        }else if (command == "RTR")
        {
            transform.Rotate(0, 0, 90);
        } else {
                input = new Vector3(Input.GetAxisRaw("Horizontal"), -1, Input.GetAxisRaw("Vertical"));
        }
                
        }
        

        void serialListener()
        {
            command = serial_script.command;
            serial2Output();
            //Debug.Log("Command: " + command);
    }


        void Start()
        {
            serial_script = GameObject.Find("SerialMaster").GetComponent("SerialRead") as SerialRead;


        }

        // Update is called once per frame
        void Update()
        {
        /*
        //test the movement of the robot
        a.ind = 2;      //should go to cubicle 2
        transform.position = Vector3.MoveTowards(transform.position, empPoints[a.ind].position, moveSpeed * Time.deltaTime);
        */
        //Controlled movement - responds to pressing up, down, left, and right arrow keys

            if (counter >= 8)
            {
                serialListener();
                counter = 0;
            }
            

            
            if (GetComponent<Rigidbody>().velocity.magnitude < maxSpeed)
            //Debug.Log();
            {
                GetComponent<Rigidbody>().AddForce(input*moveSpeed);
            }


            counter++;
        }
    }

//}
