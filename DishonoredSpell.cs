using UnityEngine;
using System.Collections;

public class DishonoredSpell : MonoBehaviour {

    private RaycastHit lastRaycastHit;
    public AudioClip audioClip;
    public float range = 1000;

    private GameObject GetLookedAtObject()
    {
        Vector3 origin = transform.position;
        Vector3 direction = Camera.main.transform.forward;
        if (Physics.Raycast(origin, direction, out lastRaycastHit, range))
        {
            return lastRaycastHit.collider.gameObject;
        }
        else
        {
            return null;
        }
    }

    private void TeleportToLookAt()
    {
        transform.position = lastRaycastHit.point + lastRaycastHit.normal * 1.5f;
        if (audioClip != null)
            AudioSource.PlayClipAtPoint(audioClip, transform.position);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
            if (GetLookedAtObject() != null)
                TeleportToLookAt();
    }


}
