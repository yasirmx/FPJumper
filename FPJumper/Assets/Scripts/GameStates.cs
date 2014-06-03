using UnityEngine;
using System.Collections;

public class GameStates : MonoBehaviour {
	
	public Texture btnTexture;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public void RestartGame()
	{
		
	}
	
	public void PauseGame()
	{
		
	}
	
    void OnGUI() {
        if (!btnTexture) {
            Debug.LogError("Please assign a texture on the inspector");
            return;
        }
      //  if (GUI.Button(new Rect(10, 10, 50, 50), btnTexture))
        //    Debug.Log("Clicked the button with an image");
        
        if (GUI.Button(new Rect(10, 240, 100, 60), "Use"))
            Debug.Log("Clicked the button with text");
        
		if (GUI.Button(new Rect(370, 240, 100, 60), "Jump"))
            Debug.Log("Clicked the button with text");
    }
}
