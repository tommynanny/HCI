using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class Manager : MonoBehaviour
{

	public static Manager instance = null;
	public List<Transform> Pages;
	public Page page;

	[System.Serializable]
	public class Page
	{
		public Transform ForumPage;
		public Transform MapPage;
		public Transform ProfilePage;
		public Transform GroupPage;
		public Transform MenuPage;
	}
	private void Awake()
	{
		if (instance == null)
		{
			instance = this;
			DontDestroyOnLoad(this);
		}
		else
		{
			Destroy(this);
		}
	}

	private void Start()
	{
		//Pages = new List<Transform>();
		//foreach (Transform child in transform)
		//{
		//    string first = child.name.Substring(0, 1);
		//    int pageIndex;
		//    if (int.TryParse(first, out pageIndex)) // is number beginning name
		//    {
		//        Pages.Add(transform);
		//        //Pages = Pages.OrderBy(go => go.name).ToList<Transform>();
		//    }
		//}
	}

	public void GoToPage(string name)
	{
		foreach (Transform p in Pages)
		{
			if (p.name != name)
			{
				p.gameObject.SetActive(false);
			}
			else
			{
				p.gameObject.SetActive(true);
			}
		}
	}

	public void GoToPage(Transform page)
	{
		GoToPage(page.name);
	}

	public void GoToPage(int x)
	{
		for (int i = 0; i < Pages.Count; i++)
		{
			if (i != x)
			{
				Pages[i].gameObject.SetActive(false);
			}
			else
			{
				Pages[i].gameObject.SetActive(true);
			}
		}
	}

	public void HideAllPage()
	{
		foreach (Transform p in Pages)
		{
			p.gameObject.SetActive(false);
		}
	}
	public void GotoForum()
	{
		GoToPage(page.ForumPage);
	}

	public void GotoMap()
	{
		GoToPage(page.MapPage);
	}

	public void GotoProfile()
	{
		GoToPage(page.ProfilePage);
	}

	public void GotoGroup()
	{
		GoToPage(page.GroupPage);
	}

	public void GotoMenu()
	{
		GoToPage(page.MenuPage);
	}


}
