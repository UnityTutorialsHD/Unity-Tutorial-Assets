using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowQuest2 : MonoBehaviour {

    public GameObject questUI;
    public GameObject showQuest;

    bool entered = false;
    bool alreadyPlayed = false;
    
    public AudioClip sound;
    private AudioSource audio;

    void Start () {

        audio = GetComponent<AudioSource>();
        showQuest.SetActive(false);
        questUI.SetActive(false);
	}
	
	void OnTriggerEnter (Collider other) {
        if (other.tag == "Player" && !alreadyPlayed && !entered)
        {
            questUI.SetActive(true);
            showQuest.SetActive(true);
            audio.PlayOneShot(sound, 5);
            alreadyPlayed = true;
            entered = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            Destroy(showQuest);
        }
    }
}
