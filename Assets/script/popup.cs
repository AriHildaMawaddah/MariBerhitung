using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class popup : MonoBehaviour {
    public GameObject PopUp;
    public bool aktif;
	// Use this for initialization
	void Start () {
		
	}
    void OnMouseDown()
    {
        PopUp.SetActive(aktif);
    }
    // Update is called once per frame
    void Update () {
		
	}
}
