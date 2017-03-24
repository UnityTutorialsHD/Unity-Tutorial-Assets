using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountObjects : MonoBehaviour {
    public string nextLevel;
    public GameObject objToDestroy;
    GameObject objUI;
	// Use this for initialization
	void Start()
    {
        objUI = GameObject.Find("ObjectNum");
    }
	// Update is called once per frame
	void Update () {
        objUI.GetComponent<Text>().text = ObjectsToCollect.objects.ToString();
        if (ObjectsToCollect.objects == 0)
        {
            Application.LoadLevel(nextLevel);
            //Destroy(objToDestroy);
            objUI.GetComponent<Text>().text = "All objects collected.";
        }

	}
}
