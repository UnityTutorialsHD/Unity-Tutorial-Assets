using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestMarker : MonoBehaviour {
    private GameObject player;
    private Vector3 playerPoint;
    private Quaternion objRot;
	// Use this for initialization
	void Start () {
        player = GameObject.FindWithTag("MainCamera");
	}
	
	// Update is called once per frame
	void Update () {

        playerPoint = new Vector3(player.transform.position.x, transform.position.y, player.transform.position.z) - transform.position;
        objRot = Quaternion.LookRotation(-playerPoint, Vector3.up);
        transform.rotation = Quaternion.Slerp(transform.rotation, objRot, Time.deltaTime * 5);
    }
}

