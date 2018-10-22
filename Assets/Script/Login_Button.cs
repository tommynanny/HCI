using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Login_Button : MonoBehaviour {
    public bool canPress;

    public void LoginUpdate(string str)
    {
        switch (str)
        {
            case "nannie":
            case "careyuyu":
            case "snichola":
            case "mattc97":
			case "hci":
				canPress = true;
                break;
            default:
                canPress = false;
                break;
        }
    }

    public void Login_Click()
    {
        if (!canPress) return;
		Manager.instance.GotoMenu();
    }


}
