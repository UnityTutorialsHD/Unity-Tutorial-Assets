using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vendor : MonoBehaviour {

    Currency script;

    public GameObject vendorUI;
    public GameObject objToCreate;
    public Transform posToCreate;

    public int cost;

    void Start()
    {
        script = GameObject.FindWithTag("GameController").GetComponent<Currency>();
    }
    void OnTriggerEnter()
    {
        vendorUI.SetActive(true);
        Cursor.visible = true;
    }
	
	// Update is called once per frame
	void OnTriggerExit ()
    {
        vendorUI.SetActive(false);
        Cursor.visible = false;
    }
    public void BuyItem()
    {
        if (script.gold >= cost)
        {
            script.gold -= cost;
            Instantiate(objToCreate, posToCreate.position, posToCreate.rotation);
        }
        else
        {
            Debug.Log("faggot");
        }
    }
}
