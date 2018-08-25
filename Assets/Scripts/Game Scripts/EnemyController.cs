using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {
	
	public float moveByPoints;
	public float speedMove;

	void Update () {
		//Remove object
		if (gameObject.transform.position.z <= -30) Destroy(gameObject);
	}

	void FixedUpdate () {
		gameObject.transform.position = Vector3.Lerp(gameObject.transform.position,
		                                             new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z - moveByPoints),
		                                             Time.deltaTime * speedMove);
	}
}
