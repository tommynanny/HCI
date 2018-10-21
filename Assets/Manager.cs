using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class Manager : MonoBehaviour
{

    public static Manager instance = null;
    public List<Transform> Pages;
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
        }
    }

    public void GoToPage(int x)
    {
        foreach (Transform p in Pages)
        {
            p.gameObject.SetActive(false);
        }
        Pages[x-1].gameObject.SetActive(true);
    }




}
