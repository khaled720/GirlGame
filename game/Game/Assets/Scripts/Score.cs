using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public Transform girl;
	public Text scoreText;
	
	// Update is called once per frame
	void Update () {
		scoreText.text = girl.position.z.ToString("0");
	}
}
