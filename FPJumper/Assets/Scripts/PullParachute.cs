using UnityEngine;
using System.Collections;

public class PullParachute : MonoBehaviour {

	public SkydivingControl controlScript;
	public GameObject Parachute;
	public GameObject Reserve;
	public MouseOrbit cameraControl;
	public GameObject MainCamera;
	public GameObject bloodSplatter;
	private Transform CameraPosition;
	private bool ParachutePulled = false;
	private bool ReservePulled = false;
	
	public AudioSource parachuterAudio;
	
	// Use this for initialization
	void Start () {
		CameraPosition = MainCamera.transform;
		cameraControl.enabled = true;
	}
	
	void OnCollisionEnter (Collision collider)
	{
		if (collider.gameObject.name == "GoogleMaps")
		{
			parachuterAudio.Play();
			bloodSplatter.SetActive(true);
		}
	}
	
	void OnTriggerEnter ()
	{
		Debug.Log("Trigger");
		controlScript.PlayerIsOnSurface = false;
		controlScript.PlayerIsFreeFalling = true;
		cameraControl.enabled = false;
		MainCamera.transform.localPosition = new Vector3(0,0,0);
		MainCamera.transform.localRotation = Quaternion.identity;
	}
	
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space))
		{
			PulledParachute();
		}
	}
	
	public void PulledParachute()
	{
		if (!ParachutePulled && !ReservePulled)
		{
			cameraControl.enabled = true;
			//gameObject.rigidbody.drag = 1F;
			Parachute.SetActive(true);
			ParachutePulled = true;
		}
		else if (ParachutePulled && !ReservePulled)
		{
			// Try to Detach Parachute
			Parachute.SetActive(false);
			ReservePulled = true;
			Reserve.SetActive(true);
		}
		else if (ParachutePulled && ReservePulled)
		{
			Reserve.SetActive(false);
			cameraControl.enabled = false;
			MainCamera.transform.rotation = CameraPosition.rotation;
			gameObject.rigidbody.drag = 0F;
		}
	}
}
