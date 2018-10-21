using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackButton : MonoBehaviour {

    // Use this for initialization
    public void Back_Click()
    {
        Manager.instance.GoToPage(1);
    }
}
