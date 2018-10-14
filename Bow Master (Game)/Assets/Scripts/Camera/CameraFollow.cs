﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	public Transform target;

	public float speed;
	public float smoothSpeed = 0.125f;

	private Vector2 startPos;
	private Vector2 targetPos;
	private Vector2 directionToTarget;

	public bool isZoomingOut = false;

	private float elapsed = 0f;
	private float duration = 1f;
	private float prevZoom;
	private float targetZoom;

	void Start() {
		Camera.main.orthographic = true;
		prevZoom = Camera.main.orthographicSize;
		targetZoom = prevZoom;
	}

	void Update() {
		elapsed += Time.deltaTime / duration;
		Camera.main.orthographicSize = Mathf.Lerp(prevZoom, targetZoom, elapsed);
	}

	void LateUpdate() {
		float mouseX = (Input.mousePosition.x / Screen.width);
		float mouseY = (Input.mousePosition.y / Screen.height);

		startPos = transform.position;
		targetPos = 
			new Vector2(target.position.x + mouseX,
						target.position.y + mouseY);
		directionToTarget = targetPos - startPos;

		float distance = Vector2.Distance(targetPos, transform.position);

		transform.Translate((directionToTarget.x * (speed - distance/10) * Time.deltaTime),
							(directionToTarget.y * (speed - distance/10) * Time.deltaTime),
							0f);
		
		// if (target) {
		// 	Vector3 desiredPosition = target.position + offset;
		// 	transform.position = desiredPosition;
		// }
	
	}

	public void CameraZoom(float targZoom) {
		elapsed = 0f;
		prevZoom = Camera.main.orthographicSize;
		targetZoom = targZoom;
	}
}
