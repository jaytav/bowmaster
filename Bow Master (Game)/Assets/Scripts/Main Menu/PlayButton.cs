﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayButton : MonoBehaviour {

	public MainMenu mainMenu;

	void OnTriggerEnter2D(Collider2D col) {
		if (col.tag == "ButtonPresser") {
			mainMenu.PlayGame();
		}
	}
}
