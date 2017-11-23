using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComboHit : MonoBehaviour
{
    Animator mAnim;

    void Start()
    {
        mAnim = GameObject.FindWithTag("Player").GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            mAnim.SetTrigger("punch");
        }
    }
}
