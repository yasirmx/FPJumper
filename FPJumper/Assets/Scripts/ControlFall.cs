using UnityEngine;
using System.Collections;

public class ControlFall : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if ( Input.GetKey(KeyCode.UpArrow) )	
		{
			transform.Rotate(0, 0, 2);
		}
		if ( Input.GetKey(KeyCode.DownArrow) )	
		{
			transform.Rotate(0, 0, -2);
		}
		if ( Input.GetKey(KeyCode.LeftArrow) )	
		{
			transform.Rotate(0, -2, 0);
		}
		if ( Input.GetKey(KeyCode.RightArrow) )	
		{
			transform.Rotate(0, 2, 0);
		}
	}
}
