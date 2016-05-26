using UnityEngine;
using System.Collections;

public class Quest : MonoBehaviour {

    [SerializeField]
     bool showObjective = false;
    [SerializeField]
    Texture objective;
    [SerializeField]
    private int collision;

    void Start()
    {
        showObjective = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && showObjective == false && collision == 0)
        showObjective = true;
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
            showObjective = false;
        collision = 1;
    }
    void OnGUI()
    {
        if (showObjective == true)
            GUI.DrawTexture(new Rect(Screen.width / 1.5f, Screen.height / 1.4f, 178, 178), objective);
    }

    void Update()
    {
        if (Input.GetButton("ShowObj")&& collision == 1)
        {
            showObjective = true;
        }
         if (Input.GetButtonUp("ShowObj") && collision == 1)
        {
            showObjective = false;
        }
    }
    }
