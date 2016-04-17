using UnityEngine;
using System.Collections;

public class SpawnWhenHit : MonoBehaviour {

    public bool flag = true;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision other)
    {
        if (flag)
        {
            itemSpawn.S.SpawnBlock();
            this.GetComponent<Rigidbody>().useGravity = false;
            this.GetComponent<Rigidbody>().isKinematic = true;
            flag = false;

        }
    }
}
