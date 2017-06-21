using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vendor : MonoBehaviour {

    Currency script;
    Inventory invScript;

    public GameObject vendorUI;

    public int cost;

    void Start()
    {
        vendorUI.SetActive(false);
        script = GameObject.FindWithTag("GameController").GetComponent<Currency>();
        invScript = GameObject.FindWithTag("GameController").GetComponent<Inventory>();
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
    public void BuyItem(GameObject objToCreate)
    {
        if (script.gold >= cost)
        {
            script.gold -= cost;
            GameObject i = Instantiate(objToCreate);
            i.transform.SetParent(invScript.invTab.transform);
        }
    }
}
