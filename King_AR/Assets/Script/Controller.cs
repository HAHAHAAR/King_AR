using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class Controller : MonoBehaviour {

	// Use this for initialization
    public static Controller instance;
    public GameObject Canvas;
    public GameObject BG;
    public Toggle[] mainImage;
    float doubleTimes = 0;
    int doubleClick = 0;
    int currentBlockNum = 0;
    float invokeTime = 15f;
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
	void Start () {
        Debug.Log(mainImage.Length);
        for(int i=0;i<mainImage.Length;i++)
        {
            mainImage[i].gameObject.SetActive(false);

        }
        InvokeRepeating("Show", 0.1f,0.7f);
	}
    

    Toggle tg;
	// Update is called once per frame
	void Update () {
        doubleTimes += Time.deltaTime;
        if (doubleTimes > 0.6f)
        {
            doubleClick = 0;
            doubleTimes = 0;
        }
        if (Input.GetMouseButtonUp(0))
        {
            doubleClick++;
        }
        if (doubleClick >= 2)
        {
            CameraDevice.Instance.SetFocusMode(CameraDevice.FocusMode.FOCUS_MODE_TRIGGERAUTO);
        }
        ToggleClick();
	}
    int a = 0;
    void Show() 
    {
        if (Canvas.transform.localRotation.x>=0.45&&a<=6)
        {
            mainImage[a].gameObject.SetActive(true);
            a++;
        }
       
    }
    void ToggleClick() 
    {
        for (int i = 0; i < mainImage.Length; i++)
        {
            if (mainImage[i].isOn)
            {
                Canvas.SetActive(false);
                BG.SetActive(false);
            }
        }
    }
}
