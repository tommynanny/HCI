using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LegendWindowButton : MonoBehaviour
{
	Animator animator;
	// Use this for initialization
	void Start()
	{
		animator = GetComponent<Animator>();
	}

	// Update is called once per frame
	public void ShowLegendWindow()
	{
		animator.SetBool("Show", true);
	}

	public void HideLegendWindow()
	{
		animator.SetBool("Show", false);
	}
}
