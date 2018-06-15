using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossAnimate : MonoBehaviour {
    public GameObject UpCur, DownCur, LeftCur, RightCur;

    void Update()
	{
        if(Input.GetButtonDown("Fire1")) {
            UpCur.GetComponent<Animator>().enabled = true;
            DownCur.GetComponent<Animator>().enabled = true;
            LeftCur.GetComponent<Animator>().enabled = true;
            RightCur.GetComponent<Animator>().enabled = true;
            WaitingAnim();
            StartCoroutine(WaitSecond());
        }
	}

    void WaitingAnim() {
        StartCoroutine(WaitSecond());
        UpCur.GetComponent<Animator>().enabled = false;
        DownCur.GetComponent<Animator>().enabled = false;
        LeftCur.GetComponent<Animator>().enabled = false;
        RightCur.GetComponent<Animator>().enabled = false;
    }

    IEnumerator WaitSecond(){
        yield return new WaitForSeconds(0.1f);
        yield return null;
    }
}
