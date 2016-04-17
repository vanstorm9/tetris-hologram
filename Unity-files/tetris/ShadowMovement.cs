using UnityEngine;
using System.Collections;

public class ShadowMovement : MonoBehaviour {

    public float moveSpeed;
    private float maxSpeed = 5f;
    private static GameObject targObj = GameObject.FindGameObjectWithTag("L-block");
    private Vector3 targPos = new Vector3(targObj.transform.position.x, 0, targObj.transform.position.z);
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        transform.position = Vector3.MoveTowards(transform.position, targPos, 1);
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
