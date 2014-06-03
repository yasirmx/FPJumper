using UnityEngine;
using System.Collections;

public class SkyDiveMenuControls : MonoBehaviour {

	public UILabel googleLocation;
	public UILabel longitudeLabel;
	public UILabel latitudeLabel;



	public void OnGameStart()
	{
		if (googleLocation != null)
		{
			PlayerPrefs.SetString("GoogleLocation", googleLocation.text);
		}
		else
		{
			if (longitudeLabel != null && latitudeLabel != null)
			{
				PlayerPrefs.SetFloat("LongitudeLocation", float.Parse(longitudeLabel.text));
				PlayerPrefs.SetFloat("LatitudeLocation", float.Parse(latitudeLabel.text));
			}
		}
	}
}
