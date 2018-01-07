using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayVideo : MonoBehaviour {

    public GameObject videoPlayer;
    public int timeToStop;

	// Use this for initialization
	void Start () {
        videoPlayer.SetActive(false);
	}
	
	// Update is called once per frame
	void OnTriggerEnter (Collider player) {

        if (player.gameObject.tag == "Player")
        {
            videoPlayer.SetActive(true);
            Destroy(videoPlayer, timeToStop);
        }
	}
}
