using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class NumberWizard : MonoBehaviour {
	// Use this for initialization
	int max;
	int min;
	int guess;
	
	public int maxGuessesAllowed = 25;
	
	public Text text;
	
	void Start() {
		StartGame();
		NextGuess();
	}
	
	void StartGame(){
		max = 10000;
		min = 1;
		guess = 5000;
		
	}
	


	public void GuessHigher(){
			min = guess +1;
			NextGuess ();
	}
	
	public void GuessLower(){
		max = guess + 1;
		NextGuess();
	}
		
	void NextGuess() {
		guess = Random.Range (min,max);
		text.text = guess.ToString();
		maxGuessesAllowed = maxGuessesAllowed - 1;
		if(maxGuessesAllowed <= 0){
			Application.LoadLevel("Win");
		}
	}
}
	 
 