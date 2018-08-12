﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobeTrigger : MonoBehaviour {

    Animator anim;

	void Start () {
        anim = GetComponent<Animator>();
	}
	
	void Update () {
		if(Input.GetMouseButtonDown(0))
        {
            anim.SetTrigger("Globe_Trigger");
        }
	}
}
