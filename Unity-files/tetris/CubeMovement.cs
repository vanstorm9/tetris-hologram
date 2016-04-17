using UnityEngine;
using System.Collections;



/*namespace BMove
{

    public class A
    {
        public int ind;

    }
    */
    
    public class CubeMovement : MonoBehaviour
    {
    /*
        public A a;
        public void moveBot(int indx)
        {
            a.ind = indx;
            Start();
            Update();

        }

*/
        public float moveSpeed;
        private float maxSpeed = 5f;
        private Vector3 input;
        //public Transform[] empPoints;
        // Use this for initialization

        void Start()
        {
            //transform.position = empPoints[0].position;


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
            
            input = new Vector3(Input.GetAxisRaw("Horizontal"), -1, Input.GetAxisRaw("Vertical"));
            if (GetComponent<Rigidbody>().velocity.magnitude < maxSpeed)
            //Debug.Log();
            {
                GetComponent<Rigidbody>().AddForce(input*moveSpeed);
            }

            // deprecated rigidbody.AddForce(input);

            //print(input);
            
        }
    }

//}
