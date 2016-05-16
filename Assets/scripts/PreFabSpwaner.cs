using UnityEngine;
using System.Collections;

public class PreFabSpwaner : MonoBehaviour {

	private float nextSpwan = 0;
	public Transform prefabToSpawn;
	public float spawnRate = 1 ;
	public float randomDelay = 1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Time.time > nextSpwan) 
		{
			Instantiate (prefabToSpawn, transform.position, Quaternion.identity);
			nextSpwan = Time.time + spawnRate + Random.Range (0, randomDelay);
		}
	
	}
}
