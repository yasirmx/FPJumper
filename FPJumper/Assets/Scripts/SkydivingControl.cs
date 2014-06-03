using UnityEngine;
using System.Collections;

public class SkydivingControl : MonoBehaviour {

	public bool PlayerIsOnSurface = true;
	public bool PlayerIsFreeFalling = true;

	public bool isSprint = false;
	public bool isCrouch = false;
	public float moveSpeed = 3;
	public float jumpHeight = 2;
	public float sprintSpeed = 4;   
	public float jumpHeightSprint = 2;
	public float crouchSpeed = 1.5F;   

	void Update ()	
	{
		if (PlayerIsOnSurface)
		{
			PlayerOnSurface();
		}
		else
		{
			if (PlayerIsFreeFalling)
			{
				PlayerFreeFalling();
			}
		}
	}	

	private void PlayerIsParacuting()
	{

	}

	private void PlayerFreeFalling()
	{
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

	private void PlayerOnSurface()
	{
		if(isSprint == false && isCrouch == false)
		{       
			Debug.Log("Jump");
			float moveX = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
			float moveZ = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
			float moveY = Input.GetAxis("Jump") * jumpHeight * Time.deltaTime;
			transform.Translate(moveX,moveY,moveZ);
		}
		
		if(isSprint == true)		
		{       		
			float moveXS = Input.GetAxis("Horizontal") * sprintSpeed * Time.deltaTime;			
			float moveYS = Input.GetAxis("Jump") * jumpHeightSprint * Time.deltaTime;
			float moveZS = Input.GetAxis("Vertical") * sprintSpeed * Time.deltaTime;
			transform.Translate(moveXS,moveYS,moveZS);
		}
		
		if(Input.GetKeyDown(KeyCode.LeftShift) && isSprint == false)
		{
			isSprint = true;
		}
		
		else if(Input.GetKeyUp(KeyCode.LeftShift) && isSprint == true)
			
		{
			isSprint = false;
		}
		
		if(isCrouch == true)
		{       
			float moveXC = Input.GetAxis("Horizontal") * crouchSpeed * Time.deltaTime;
			
			float moveZC = Input.GetAxis("Vertical") * crouchSpeed * Time.deltaTime;
			
			transform.Translate(moveXC,0,moveZC);
			
		}  
		
		if(Input.GetKeyDown(KeyCode.LeftControl) && isCrouch == false)	
		{
			isCrouch = true;
		}
		
		else if(Input.GetKeyUp(KeyCode.LeftControl) && isCrouch == true)
		{
			isCrouch = false;	
		}
	}
}