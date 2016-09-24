using UnityEngine;
using System.Collections;

public class DestroyOnTrigger : MonoBehaviour
{
    public GameObject objToDestroy;
    public GameObject effect;

    // Use this for initialization
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
            Instantiate(effect, objToDestroy.transform.position, objToDestroy.transform.rotation);
            Destroy(objToDestroy);
    }
}