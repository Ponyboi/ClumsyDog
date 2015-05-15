using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	private Vector3 offset;
	public float distanceAway;
	public float distanceUp;
	public float cameraTilt;
	public float cameraGrowth;
	public float smooth;
	public float rotateSpeed;
	private Vector3 upVector;
	private Vector3 forwardVector;
	private float angle;
	GameObject playerRotation;
	GameObject cameraRotation;
	PlayerCharacterController player;
	// Use this for initialization
	void Start () {
		playerRotation = new GameObject("_rotation");
		cameraRotation = new GameObject("_CamRotation");
		player = GameObject.Find("Player").GetComponent<PlayerCharacterController>();
//		upVector = player.transform.up;
//		forwardVector  = player.transform.forward;
		offset = player.transform.position + 
			upVector * (distanceUp) - 
			forwardVector * (distanceAway);
	}
	
	// Update is called once per frame
	void Update () {

//		offset = player.transform.position + 
//			playerRotation.transform.up * (distanceUp) - 
//				playerRotation.transform.forward * (distanceAway);
//
//		playerRotation.transform.position = player.transform.position;
//		cameraRotation.transform.position = offset;
//		cameraRotation.transform.parent = playerRotation.transform;
//
//		angle += Input.GetAxis("Mouse X") * rotateSpeed;
//			
//		playerRotation.transform.rotation = Quaternion.AngleAxis(angle , playerRotation.transform.up);
//		//Debug.DrawRay(playerRotation.transform.position, playerRotation.transform.forward * 10, Color.blue);
//
//		transform.position = Vector3.Lerp(transform.position, player.transform.position, Time.deltaTime * smooth);
//
//		Vector3 velocity = new Vector3(0.8f, 0.8f, 0.8f);//Vector3.one;
//		
//		//transform.position = Vector3.SmoothDamp(transform.position, cameraRotation.transform.position, ref velocity, smooth);
//
//		Vector3 relativePos = player.transform.position - transform.position;
//		Quaternion rotation = Quaternion.LookRotation(relativePos + (Vector3.up * cameraTilt));
//		transform.rotation = rotation;
//		transform.position = offset + player.transform.position;
		Vector3 playerXPos = new Vector3( player.transform.position.x, 3.5f,  -1);
		//offset = playerXPos + playerRotation.transform.up * (distanceUp) - playerRotation.transform.forward * (distanceAway);
		transform.position = Vector3.Lerp(transform.position, playerXPos, Time.deltaTime * smooth);
		
	}
}
