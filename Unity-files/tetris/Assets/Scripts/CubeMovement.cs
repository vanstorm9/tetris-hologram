using UnityEngine;
using System.Collections;

    
    public class CubeMovement : MonoBehaviour
    {

        public float moveSpeed;
        private float maxSpeed = 5f;
        private Vector3 input;
        SerialRead serial_script;
        public string command;
        private Vector3 absolute_pos;

        int counter = 0;
        bool disable = false;

        void OnCollisionEnter(Collision col)
        {
        //if (col.gameObject.name == "Floor")
        //{
            //transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            //absolute_pos = transform.position;
      
            disable = true;
            //itemSpawn temp = GameObject.Find("SpawnPoint").GetComponent("itemSpawn") as itemSpawn;
            //temp.SpawnBlock();

    

            Debug.Log("Next Block Next Block");

        
        //this.disable = true;
            //}
        }


    void serial2Output()
        {
        if (command == "U") {
            //input = new Vector3(0, -1, 15);
            transform.position = new Vector3(transform.position.x, transform.position.y-1, transform.position.z+1);
        } else if (command == "D") {
            //input = new Vector3(0, -1, -15);
            transform.position = new Vector3(transform.position.x, transform.position.y-1, transform.position.z-1);
        } else if (command == "L") {
            //input = new Vector3(-15, -1, 0);
            transform.position = new Vector3(transform.position.x - 1, transform.position.y-1, transform.position.z);
        } else if (command == "R") {
            transform.position = new Vector3(transform.position.x + 1, transform.position.y-1, transform.position.z);
            //input = new Vector3(15, -1, 0);
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
            
    }


        void Start()
        {
            serial_script = GameObject.Find("SerialMaster").GetComponent("SerialRead") as SerialRead;


        }

        // Update is called once per frame
        void Update()
        {

            if (!disable)
            {
                if (counter >= 10)
                {
                    serialListener();
                    counter = 0;
                }

           // transform.position = new Vector3(transform.position.x, transform.position.y - 1, transform.position.z + 1);

           /* if (GetComponent<Rigidbody>().velocity.magnitude < maxSpeed)
                {
                    GetComponent<Rigidbody>().AddForce(input * moveSpeed);
                }*/
            Debug.Log(counter);

                counter++;
            }else {
                //transform.position = absolute_pos;
                this.disable = true;
            }
        }
    }

//}
