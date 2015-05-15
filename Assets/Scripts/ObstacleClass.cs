using UnityEngine;
using System.Collections;

public class ObstacleClass : MonoBehaviour {
	public float weight;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	public bool isDestroyed(){
		return false;
	}

	public float getWeight(){
			return weight;
	}
}
