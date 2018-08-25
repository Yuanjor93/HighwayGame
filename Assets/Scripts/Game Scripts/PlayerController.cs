using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

	int score;
	public float timeToChangeScore;
	bool gameIsPlay;
	
	bool movePlayer;
	bool movePlayerToLeft;
	public float movePlayerByPoints;
	public float speedMovePlayer;
	
	public GameObject changeSceneObject;
	public Text labelScore;
	
	void Start () {
		score = 0;
		gameIsPlay = true;
		InvokeRepeating("ChangeScore", 0f, timeToChangeScore);
	}

	void Update () {
		if (gameIsPlay) {
			if(Input.GetButton("Fire1")) {
				if (Input.mousePosition.x < Screen.width / 2) {
					movePlayer = true;
					movePlayerToLeft = true;
				}
				else {
					movePlayer = true;
					movePlayerToLeft = false;
				}
			}
			else {
				movePlayer = false;
			}
		}
	}
	
	void FixedUpdate () {
		if (gameIsPlay) {
			//Moving player
			if (movePlayer) {
				if (movePlayerToLeft) {
					gameObject.transform.position = Vector3.Lerp(gameObject.transform.position,
					                                             new Vector3(gameObject.transform.position.x - movePlayerByPoints, gameObject.transform.position.y, gameObject.transform.position.z),
					                                             Time.deltaTime * speedMovePlayer);
				}
				else {
					gameObject.transform.position = Vector3.Lerp(gameObject.transform.position,
					                                             new Vector3(gameObject.transform.position.x + movePlayerByPoints, gameObject.transform.position.y, gameObject.transform.position.z),
					                                             Time.deltaTime * speedMovePlayer);
				}
			}
		}
	}
	
	void ChangeScore () {
		if (gameIsPlay) {
			score++;
			labelScore.text = score.ToString();
		}
	}
	
	void OnCollisionEnter (Collision col) {
		if (gameIsPlay) {
			if (col.gameObject.tag == "Enemy")  {	
				gameIsPlay = false;
				
				//Save score
				PlayerPrefs.SetInt("CurrentScore", score);
				if (score > PlayerPrefs.GetInt("HighScore")) {
					PlayerPrefs.SetInt("HighScore", score);
					PlayerPrefs.SetInt("New best score", 1);
				}
				else {
					PlayerPrefs.SetInt("New best score", 0);
				}
				
				//Change scene
				changeSceneObject.GetComponent<ChangeScenes>().ChangeSceneToEnd();
			}
		}
	}
}
