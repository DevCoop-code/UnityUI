using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderEventScript : MonoBehaviour {

	public Slider slider;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		slider.value = Mathf.MoveTowards (slider.value, 1, 0.001f);
	}
}
