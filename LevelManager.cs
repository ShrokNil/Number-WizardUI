using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

public void Loadlevel (string name) {
		Debug.Log("Level Code requested for "+name);
		Application.LoadLevel(name);
	}
	
	public void QuitRequest(){
		Debug.Log("I want to quit!");
		Application.Quit();
	}


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	
	}
}
