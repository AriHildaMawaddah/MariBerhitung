using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tombol : MonoBehaviour {
	// Use this for initialization
	void Start () {
		
	}
	public void scene(string scene){
		Debug.Log("a");
		SceneManager.LoadScene(scene);
	}
	public void scale(float scale){
		transform.localScale = new Vector2 (1/scale,1*scale);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
