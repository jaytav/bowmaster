﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSlider : MonoBehaviour {

	private Slider slider;
	private AudioSource source;

	void Start() {
		slider = GetComponent<Slider>();
		source = SoundManager.instance.sources[0];
		slider.value = source.volume;
		slider.onValueChanged.AddListener(delegate { ValueChangeCheck(); });
	}

	void ValueChangeCheck() {
		source.volume = slider.value;
	}
}
