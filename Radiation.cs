using UnityEngine;
using System.Collections;

public class Radiation : MonoBehaviour
{
    public GameObject radiationEffect;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            radiationEffect.SetActive(true);
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            radiationEffect.SetActive(false);
        }
    }
}
