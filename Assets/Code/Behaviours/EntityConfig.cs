﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EntityConfig : MonoBehaviour {

	public PointBehaviour pointPrefab;
	public LineBehaviour linePrefab;
	public LineRenderer lineCanvasPrefab;
	public static EntityConfig instance;
	public ConstraintBehaviour constraint;
	public Text labelPrefab;

	void Start () {
		instance = this;
	}
}
