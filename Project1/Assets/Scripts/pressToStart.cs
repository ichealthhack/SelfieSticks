﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pressToStart : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetButtonDown ("Fire1")) {
		
			//SceneManager.LoadScene ("playGame");
			AutoFade.LoadLevel("playGame" ,3,1,Color.black);
		}

	}
}