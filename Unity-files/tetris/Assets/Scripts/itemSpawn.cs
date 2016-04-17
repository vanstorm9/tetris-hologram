using UnityEngine;
using System.Collections;

public class itemSpawn : MonoBehaviour {

	public Transform spawnPoint;
	public float spawnTime = 2.0f;
	public GameObject[] block;


	// Use this for initialization
	void Start () {
        SpawnBlock();
    }
	



	// Update is called once per frame
	void Update () {
        /*
		if (Input.anyKeyDown) {
			SpawnBlock ();
		}
        */
	}

	public void SpawnBlock () {

		int objectIndex = Random.Range (0, block.Length);
		Instantiate (block [objectIndex], spawnPoint.position, spawnPoint.rotation);
	}
}
