using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {

	// Use this for initialization
    public static Controller instance;
    public GameObject Canvas;
    public GameObject BG;


    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
