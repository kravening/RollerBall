﻿using UnityEngine;
using System.Collections;

public class Restart : MonoBehaviour {

	void Update () {
		if (Input.GetKeyDown (KeyCode.Return)) 
		{  
			Application.LoadLevel (0); 
		}
	}
}
