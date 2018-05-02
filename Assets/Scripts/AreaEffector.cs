using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaEffector : MonoBehaviour {
    float time;
    public GameObject EffectorDown, EffectorUp;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime;
        if (time >= 3 && time < 4)
        {
            EffectorDown.SetActive(false);
            EffectorUp.SetActive(false);
        }
        else if (time > 4)
        {
            EffectorDown.SetActive(true);
            EffectorUp.SetActive(true);
            time = 0;
        }

        Debug.Log(time);
	}
}
