﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {

	public float velocity = 45f;

	void Update()
	{
		transform.Rotate (new Vector3 (0, 0, velocity) * Time.deltaTime);
	}
}