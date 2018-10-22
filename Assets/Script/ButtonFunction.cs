using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonFuction : MonoBehaviour {

    public int GotoPageIndex;
    public void GoToPage()
    {
        Manager.instance.GoToPage(GotoPageIndex);
    }
}
