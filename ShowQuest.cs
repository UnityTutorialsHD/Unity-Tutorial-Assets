using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowQuest : MonoBehaviour
{
    public GameObject questUI;
    private int collision = 0;
    public AudioClip sound;
    private AudioSource audio;
    private bool alreadyPlayed = false;
    void Start()
    {
        audio = GetComponent<AudioSource>();
        questUI.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && questUI.activeSelf == false && collision == 0 && alreadyPlayed == false)
            questUI.SetActive(true);
        audio.PlayOneShot(sound, 5);
        alreadyPlayed = true;
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
            questUI.SetActive(false);
        collision = 1;
    }
    void Update()
    {
        if (Input.GetButton("Q") && collision == 1)
        {
            questUI.SetActive(true);
            if (Input.GetButtonDown("Q"))
            {
                audio.PlayOneShot(sound, 5);
            }
        }
        if (Input.GetButtonUp("Q") && collision == 1)
        {
            questUI.SetActive(false);
        }
    }
}
