using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupMoney : MonoBehaviour {

    Currency script;

    public int addAmount;

    void Start()
    {
        script = GameObject.FindWithTag("GameController").GetComponent<Currency>();
    }

    void OnTriggerEnter(Collider obj)
    {
        if (obj.gameObject.tag == "Player")
        {
            script.gold += addAmount;
            Destroy(gameObject);
        }     
    }
}
