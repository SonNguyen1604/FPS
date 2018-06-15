using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor001 : MonoBehaviour {

    public GameObject TextDisplay;
    public float TheDistance = PlayerCasting.DistanceFromTarget;
    public GameObject TheDoor;

	void Update () {
        TheDistance = PlayerCasting.DistanceFromTarget;
        if(Input.GetButtonDown("Action")) {
            if(TheDistance <= 2) {
                OpenTheDoor();
            }
        }
	}

	private void OnMouseOver()
	{
        if(TheDistance <= 2) {
            TextDisplay.GetComponent<UnityEngine.UI.Text>().text = "Press Button";
        }
	}

	private void OnMouseExit()
	{
        TextDisplay.GetComponent<UnityEngine.UI.Text>().text = "";
	}

    IEnumerable OpenTheDoor() {
        TheDoor.GetComponent<Animator>().enabled = true;
        yield return new WaitForSeconds(1);
        TheDoor.GetComponent<Animator>().enabled = false;
        yield return new WaitForSeconds(5);
        TheDoor.GetComponent<Animator>().enabled = true;
        yield return new WaitForSeconds(1);
        TheDoor.GetComponent<Animator>().enabled = false;
    }
}
