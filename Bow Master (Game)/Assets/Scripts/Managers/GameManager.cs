﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	public Text currencyText; //currency text on UI

	private int currency; //currency value

	void Start() {
		currency = 0; //start with 0 currency
		UpdateCurrency();
	}

	public void AddCurrency(int currencyAmount) { //add currency to current amount
		currency += currencyAmount;
		UpdateCurrency();
	}

	void UpdateCurrency() { //update currency text on UI
		currencyText.text = currency.ToString();
	}
}