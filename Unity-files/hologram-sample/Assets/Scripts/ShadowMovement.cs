using UnityEngine;
using System.Collections;

public class ShadowMovement : MonoBehaviour {

    public float moveSpeed;
    Transform goTo;
    //private float maxSpeed = 5f;
    //private static GameObject targObj = GameObject.FindGameObjectWithTag("L-block");
    //private Vector3 targPos = new Vector3(GameObject.FindGameObjectWithTag("L-block").transform.position.x, 2, GameObject.FindGameObjectWithTag("L-block").transform.position.z);
    // Use this for initialization
    void Start () {
        goTo = GameObject.Find("L-block").transform;
    }
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(goTo.position.x, 2, goTo.position.z);
        //transform.position = Vector3.MoveTowards(transform.position, targPos, moveSpeed*Time.deltaTime);
        /*
        input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        if (GetComponent<Rigidbody>().velocity.magnitude < maxSpeed)
        //Debug.Log();
        {
            GetComponent<Rigidbody>().AddForce(input * moveSpeed);
        }

        */

    }
}
