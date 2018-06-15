using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalAmmo : MonoBehaviour {

    public static int CurrentAmmo;
    public int InternalAmmo;
    public GameObject AmmoDisplay;

    public static int LoadedAmmo;
    public int InternalLoaded;
    public GameObject LoadedDisplay;

	void Update () {
        InternalAmmo = CurrentAmmo;
        InternalLoaded = LoadedAmmo;
        AmmoDisplay.GetComponent<UnityEngine.UI.Text>().text = InternalAmmo.ToString();
        LoadedDisplay.GetComponent<UnityEngine.UI.Text>().text = LoadedAmmo.ToString();
	}
}
