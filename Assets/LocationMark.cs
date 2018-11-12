using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocationMark : MonoBehaviour {

	public Animator YellowAnimator;
	public Animator GreenAnimator;
	public Animator BlueAnimator;
	public Animator WhiteAnimator;
	// Use this for initialization
	public void LocateYellow()
	{
		ClearAll();
		YellowAnimator.SetBool("Flash", true);
	}

	public void LocateWhite()
	{
		ClearAll();
		WhiteAnimator.SetBool("Flash", true);
	}
	public void LocateGreen()
	{
		ClearAll();
		GreenAnimator.SetBool("Flash", true);
	}
	public void LocateBlue()
	{
		ClearAll();
		BlueAnimator.SetBool("Flash", true);
	}

	public void ClearAll()
	{
		GreenAnimator.SetBool("Flash", false);
		WhiteAnimator.SetBool("Flash", false);
		YellowAnimator.SetBool("Flash", false);
		BlueAnimator.SetBool("Flash", false);
	}

}
