using UnityEngine;
using System.Collections;

public class DestroyAfterTime : MonoBehaviour
{
    public GameObject effect;
    public float Time;

    // Use this for initialization
    void Start()
    {
        Invoke("Explode", 5);
    }
    void Explode()
    {
        Instantiate(effect, gameObject.transform.position, gameObject.transform.rotation);
        Destroy(gameObject);
    }
}