using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScale : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    float x = 0f;
	// Update is called once per frame
	void Update () {
        if (transform.localScale.x <= 0.1)
        {
            x += 0.005f;
            transform.localScale = new Vector3(x, x, 0.1f);
        }
        else
        {
            Controller.instance.Canvas.SetActive(true);
        }
	}
}
