using UnityEngine;
using System.Collections;

public class CanonShoot : MonoBehaviour
{
    public Transform ballPos;
    public Rigidbody Ball;
    float forceAmount = 13000;
    public GameObject effect;

    void OnTriggerStay(Collider other)
    {
        Rigidbody ballRigid;
        if ((other.gameObject.tag == "Player") && Input.GetButtonDown("Use"))
        {
            ballRigid = Instantiate(Ball, ballPos.position, ballPos.rotation) as Rigidbody;
            ballRigid.AddForce(ballPos.forward * forceAmount);
            Instantiate(effect, ballPos.position, ballPos.rotation);
        }
   }
}
