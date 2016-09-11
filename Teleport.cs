using UnityEngine;
using System.Collections;

public class Teleport : MonoBehaviour
{
    public GameObject ui;
    public GameObject objToTP;
    public Transform tpLoc;
    void Start()
    {
        ui.SetActive(false);
    }

    void OnTriggerStay(Collider other)
    {
        ui.SetActive(true);
        if ((other.gameObject.tag == "Player") && Input.GetKeyDown(KeyCode.E))
        {
            objToTP.transform.position = tpLoc.transform.position;
        }
    }
    void OnTriggerExit()
    {
        ui.SetActive(false);
    }
}
