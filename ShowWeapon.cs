using UnityEngine;
using System.Collections;

public class ShowWeapon : MonoBehaviour
{
    [SerializeField]
    public GameObject item1;
    [SerializeField]
    public GameObject item2;
    public bool showItem1;
    public bool showItem2;
    // Use this for initialization
    void Start()
    {
        showItem1 = false;
        showItem2 = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (showItem1 == false)
        {
            item1.SetActive(false);
        }
        if (showItem1 == true)
        {
            item1.SetActive(true);
        }
        if (showItem2 == false)
        {
            item2.SetActive(false);
        }
        if (showItem2 == true)
        {
            item2.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Alpha1) && showItem1 == false)
        {
            showItem1 = true;
            showItem2 = false;
        }
        if(Input.GetKeyDown(KeyCode.Alpha2)&& showItem2 == false)
        {
            showItem2 = true;
            showItem1 = false;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            showItem2 = false;
            showItem1 = false;
        }
    }
}
