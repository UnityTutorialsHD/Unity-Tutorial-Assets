using UnityEngine;
using System.Collections;

public class EnterVehicle : MonoBehaviour {
    public GameObject Vehicle;
    public GameObject Player;
    public GameObject PlayerBackup;
    private bool inVehicle = false;
    Vehicle vehicleScript;
    GameObject guiObj;
    AudioSource source;
    public AudioClip audio;

	
void Start () {
        vehicleScript = GetComponent<Vehicle>();
        vehicleScript.enabled = false;
        source = GetComponent<AudioSource>();
        guiObj = GameObject.Find("PressE");
        guiObj.SetActive(false);
        PlayerBackup.SetActive(false);
	}

    // Update is called once per frame
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player" && inVehicle == false)
        {
            guiObj.SetActive(true);

        }
        if (other.gameObject.tag == "Player" && inVehicle == false && Input.GetKey(KeyCode.E))
        {
            source.PlayOneShot(audio, 1);
            guiObj.SetActive(false);
            PlayerBackup.SetActive(true);
            Player.SetActive(false);
            Player.transform.parent = Vehicle.transform;
            vehicleScript.enabled = true;
            inVehicle = true;
        }       
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            guiObj.SetActive(false);
        }
    }
    void Update()
    {
        if (inVehicle == true && Input.GetKey(KeyCode.F))
            {
            Player.SetActive(true);
            Player.transform.parent = null;
            PlayerBackup.SetActive(false);
            vehicleScript.enabled = false;
            inVehicle = false;
            }
    }
}
