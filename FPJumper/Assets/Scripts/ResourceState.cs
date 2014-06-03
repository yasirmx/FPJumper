using UnityEngine;
using System.Collections;
	
public class ResourceState : MonoBehaviour {
	
	public enum State {Normal,Burning,Wet,Broken};
	public State CurrentCondition;
	
	void Start()
	{
		CurrentCondition = State.Normal;
	}
	
	public void ResourceChangedState()
	{
		if (CurrentCondition == State.Normal)
		{
			//Nothing happens
		}
		else if (CurrentCondition == State.Burning)
		{
			//Turn on fire
		}
	}
}
