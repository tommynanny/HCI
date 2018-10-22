using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonFunction : MonoBehaviour {

    public int GotoPageIndex;
    public void GoToPage()
    {
        Manager.instance.GoToPage(GotoPageIndex);
    }
}
