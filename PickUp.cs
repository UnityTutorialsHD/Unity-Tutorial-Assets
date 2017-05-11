using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour {

    Animator anim;

    public bool money;
    public int moneyAmount;
    Currency moneyScript;

    public bool item;
    

	// Use this for initialization
	void Start () {

        anim = GameObject.FindWithTag("Player").GetComponent<Animator>();
        moneyScript = GameObject.FindWithTag("GameController").GetComponent<Currency>();

	}
	
	// Update is called once per frame
	void OnTriggerStay(Collider player) {
        if (player.tag == "Player")
        {
            if (money && Input.GetKeyDown(KeyCode.E))
            {
                StartCoroutine("PlayAnim");
            }
            else if(item && Input.GetKeyDown(KeyCode.E))
            {
                StartCoroutine("PlayAnim");
            }
        }		
	}

    IEnumerator PlayAnim()
    {
        anim.SetTrigger("pickup");
        yield return new WaitForSeconds(1);
        if (money)
        {
            moneyScript.gold += moneyAmount;
            Destroy(gameObject);
        }
        else if (item)
        {
            //pick up object or add it to your inventory
        }
    }
}
