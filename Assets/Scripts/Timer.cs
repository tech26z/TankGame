using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
    float time;
    int minutes;
    int seconds;

	// Use this for initialization
	void Start () {
        time = 50f;
        GameObject.Find("timerUI").GetComponent<Text>().text = "";
	}
	
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime;
        seconds = (int)time%60;
        minutes = (int)time/60;
        //Debug.Log(minutes + " : " + seconds);
        GameObject.Find("timerUI").GetComponent<Text>().text = minutes + ":" +
            seconds;
	}
}
