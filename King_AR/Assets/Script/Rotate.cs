using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	// Update is called once per frame
	void Update () {
            if (transform.rotation.x<=0.45 && transform.eulerAngles.x>=-1)
                    {
                        transform.Rotate (new Vector3 (1f, 0f, 0f));
                        Debug.Log(transform.rotation.x);
                    }
	}
}
