using UnityEngine;
using System.Collections;

public class AltometerScript : MonoBehaviour {
	
	public Camera GameCamera;
	public GameObject Skydiver;
	public Vector2 szPtr;
	public Rect rCircle;
	public Texture2D bigCircle;
	public Texture2D pointer;
	public float angle = 340;
	private float diverHeightPercent = 351.3817F; //35138.17F / 100
	//DiverHeight Scene 17569.14
	//TerrainHeight Scene -17569.03F
	//Total Height 35138.17
	//Maximum Height 11000;
	//3.19437909091
	private float terrainHeight = 17569.03F; // Its negitive
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 	
	{
		//float newdiverHeight = Skydiver.transform.position.y + terrainHeight;
		//newdiverHeight / diverHeightPercent;
		
		//GUIUtility.RotateAroundPivot (AltometerKnob, new Vector2(240.0f, 160.0f)); 
		//AltometerKnob.transform.Rotate(Vector3.forward * Time.deltaTime * 100);
			
	}
	
	void OnGUI()
	{
		Rect rPtr = new Rect(0, 0, 0, 0);
		Vector2 pivot;
		
		angle = 340F * PlayerHeightPercentage();
		
		if ((terrainHeight + Skydiver.transform.position.y) < 30000)
		{
			GameCamera.farClipPlane = 60000;
		}
		
		// set the pivot at the circle center
    	pivot.x = rCircle.x+rCircle.width/2;
   		pivot.y = rCircle.y+rCircle.height/2;
   		// set the pointer rect at the circle top
   		rPtr.x = pivot.x-szPtr.x/2;
   		rPtr.width = szPtr.x;
  		rPtr.y = rCircle.y-szPtr.y/2;
   		rPtr.height = szPtr.y;
 
   		GUI.DrawTexture(rCircle,bigCircle);
    	Matrix4x4 svMat = GUI.matrix;
    	GUIUtility.RotateAroundPivot(angle%360,pivot); 
    	GUI.DrawTexture(rPtr,pointer);
    	GUI.matrix = svMat; 
	}


 	public float PlayerHeightPercentage()
	{
		float newdiverHeight = Skydiver.transform.position.y + terrainHeight;
		return (newdiverHeight / diverHeightPercent) * 0.01F;
	}
}
