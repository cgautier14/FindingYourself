﻿using UnityEngine;
using System.Collections;

public class AdultText : MonoBehaviour {

	Renderer rend;

	// Use this for initialization
	void Start () {
		rend = GetComponent<Renderer>();
		rend.enabled = false;
	}

	// Update is called once per frame
	void Update () {
		if (FirstPersonDrifter.collideAdult == true) {
			rend.enabled = true;

		} else {
			rend.enabled = false;
		}
	}
}