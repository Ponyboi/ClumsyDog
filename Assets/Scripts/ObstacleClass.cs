using UnityEngine;
using System.Collections;

public class ObstacleClass : MonoBehaviour {
	public float weight;
	public bool destroyed = false;
	public Material destroyedMat;
	private Rigidbody body;
	private Vector3 prevVelocity;
	public float maxVelChange = 1;

	// Use this for initialization
	void Start () {
		body = transform.gameObject.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {

	}
	void FixedUpdate() {
		CheckBroken();
	}
	public void CheckBroken() {
		if (body != null) {
			Debug.Log ("Body: " + body.velocity.magnitude);
			Debug.Log ("Prev Vel: " + prevVelocity.magnitude);
			Debug.Log ((body.velocity - prevVelocity).magnitude);
			if ((body.velocity - prevVelocity).magnitude > maxVelChange && !destroyed) {
				destroyed = true;
				foreach (MeshRenderer childRenderer in transform.GetComponentsInChildren(typeof(MeshRenderer))) {
					childRenderer.material = destroyedMat;
				}
				Debug.Log ("changed");
			}
			prevVelocity = body.velocity;
		}
	}
//	public void changeTexture(GameObject child) {
//		child.GetComponent<MeshRenderer>().material = destroyedMat;
//	}
	public void changeTexture(MeshRenderer child) {
		child.GetComponent<MeshRenderer>().material = destroyedMat;
	}

	public bool isDestroyed(){
		return false;
	}

	public float getWeight(){
			return weight;
	}
}
