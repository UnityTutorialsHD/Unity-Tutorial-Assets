using UnityEngine;
using System.Collections;

public class SlowDownTime : MonoBehaviour {

	// Use this for initialization
	void Update () {
        if (Input.GetKey(KeyCode.Q))
        {
            Time.timeScale = 0.65f;
        }
        else
            Time.timeScale = 1;
    }	
}
