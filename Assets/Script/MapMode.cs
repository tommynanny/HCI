using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MapMode : MonoBehaviour
{
	public Transform forumButton;
	public Transform ProfileButton;
	public Transform ReportButton;
	public Transform GroupButton;
	public Transform LocateButton;
	public Transform CancelButton;
	public Transform PinReport;
	public Transform Grild;
	public Transform ReportWindow;

	public List<Transform> FriendsPin;
	List<Color> PreviousPinColor;
	List<Color> PreviousBoxColor;
	public Sprite StaticPin;

	bool reportmode = false;
	// Use this for initialization

	void OnEnable()
	{
		PreviousPinColor = new List<Color>();
		PreviousBoxColor = new List<Color>();
		for (int i = 0; i < FriendsPin.Count; i++)
		{
			Transform p = FriendsPin[i];
			PreviousPinColor.Add(p.GetComponent<Image>().color);
			PreviousBoxColor.Add(p.Find("Box").GetComponent<Image>().color);
		}
		NormalMode();
	}



	public void NormalMode()
	{
		reportmode = false;

		forumButton.gameObject.SetActive(true);
		ProfileButton.gameObject.SetActive(true);
		GroupButton.gameObject.SetActive(true);
		ReportButton.gameObject.SetActive(true);

		LocateButton.gameObject.SetActive(false);
		CancelButton.gameObject.SetActive(false);
		PinReport.gameObject.SetActive(false);
		Grild.GetComponent<Image>().color = Color.black;
		NormalModePin();
		HideReportWindow();
	}

	public void ReportMode()
	{
		reportmode = true;

		forumButton.gameObject.SetActive(false);
		ProfileButton.gameObject.SetActive(false);
		GroupButton.gameObject.SetActive(false);
		ReportButton.gameObject.SetActive(false);

		LocateButton.gameObject.SetActive(true);
		CancelButton.gameObject.SetActive(true);
		PinReport.gameObject.SetActive(true);
		Grild.GetComponent<Image>().color = Color.red;
		ReportModePin();
		HideReportWindow();
	}

	public void ReportModePin()
	{
		for (int i = 0; i < FriendsPin.Count; i++)
		{
			Transform p = FriendsPin[i];
			PreviousPinColor[i] = p.GetComponent<Image>().color;
			PreviousBoxColor[i] = p.Find("Box").GetComponent<Image>().color;
			p.GetComponent<Image>().sprite = StaticPin;
			p.GetComponent<Image>().color = Color.black;
			p.Find("Box").GetComponent<Image>().color = Color.black;
			p.GetComponent<Animator>().enabled = false;

		}
	}

	public void NormalModePin()
	{
		for (int i = 0; i < FriendsPin.Count; i++)
		{
			Transform p = FriendsPin[i];
			p.GetComponent<Image>().color = PreviousPinColor[i];
			p.Find("Box").GetComponent<Image>().color = PreviousBoxColor[i];
			p.GetComponent<Animator>().enabled = true;
		}
	}

	public void ShowReportWindow()
	{
		ReportWindow.gameObject.SetActive(true);
	}

	public void HideReportWindow()
	{
		ReportWindow.gameObject.SetActive(false);
	}
}
