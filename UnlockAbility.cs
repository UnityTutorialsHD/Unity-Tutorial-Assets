using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockAbility : MonoBehaviour
{
    public bool dishonoredSpell;
    public bool slowDownTime;
    // Use this for initialization
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            if (dishonoredSpell)
            {
                GameObject.FindWithTag("Player").GetComponent<DishonoredSpell>().enabled = true;
                Destroy(gameObject);
            }
            if (slowDownTime)
            {
                GameObject.FindWithTag("Player").GetComponent<SlowDownTime>().enabled = true;
                Destroy(gameObject);
            }
        }
    }
}
