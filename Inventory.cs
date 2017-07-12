using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {

    public GameObject invTab;

	// Use this for initialization
	void Start () {
        invTab.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.Tab))
        {
            invTab.SetActive(true);
        }
        else
        {
            invTab.SetActive(false);
        }
	}
}
