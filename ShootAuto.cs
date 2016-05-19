using UnityEngine;
using System.Collections;

using UnityEngine;
using System.Collections;

public class ShootAuto : MonoBehaviour
{
    public Transform ballPos;
    public Rigidbody Ball;
    static float timeMin = 10;
    static float timeMax = 15;
     float forceAmount = 13000;
    public GameObject effect;


    void SpawnBall()
    {
        Rigidbody ballRigid;
        if ((Ball != null) && (ballPos != null))
        {
            ballRigid = Instantiate(Ball, ballPos.position, ballPos.rotation) as Rigidbody;
            Instantiate(effect, ballPos.position, ballPos.rotation);
            if (ballRigid != null)
            {
                ballRigid.AddForce(ballPos.forward * forceAmount);
            }
            else
            {
                Debug.LogWarning("The instantiated item does not contain a Rigidbody");
            }
        }
        else
        {
            if ((Ball == null))
            {
                Debug.LogWarning("Ball has not been assigned. Please assign the Ball");
            }
            if (ballPos == null)
            {
                Debug.LogWarning("ballPos has not been assigned. Please assign the ballPos");
            }
        }
    }

    void Start()
    {
        float timeToSpawn = Random.Range(timeMin, timeMax);
        InvokeRepeating("SpawnBall", timeToSpawn, Random.Range(3, 7));
    }
}
