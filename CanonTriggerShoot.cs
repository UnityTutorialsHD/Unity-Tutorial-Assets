using UnityEngine;
using System.Collections;

public class CanonTriggerShoot : MonoBehaviour
{

    public Transform posCanonball;
    public Rigidbody Canonball;
    float forceAmount = 13000;

    void OnTriggerEnter()
    {
        Rigidbody Canonrigidbody;
        Canonrigidbody = Instantiate(Canonball, posCanonball.position, posCanonball.rotation) as Rigidbody;
        Canonrigidbody.AddForce(posCanonball.forward * forceAmount);
    }
}