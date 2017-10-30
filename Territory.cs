using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Territory : MonoBehaviour {

    public string territoryName;
    public GameObject territoryUI;

	// Use this for initialization
	void Start () {

        territoryUI.SetActive(false);
	}
	
	// Update is called once per frame
	void OnTriggerEnter (Collider player) {
		if(player.gameObject.tag == "Player")
        {
            territoryUI.SetActive(true);
            territoryUI.GetComponent<Text>().text = territoryName;
        }
	}
    void OnTriggerExit(Collider player)
    {
        if(player.gameObject.tag == "Player")
        {
            territoryUI.SetActive(false);
        }
    }
}
