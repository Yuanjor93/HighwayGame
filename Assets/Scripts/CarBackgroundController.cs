using UnityEngine;
using System.Collections;

public class CarBackgroundController : MonoBehaviour {
	
	public float moveByPoints;
	public float speedMove;
	
	void Update () {
		//Remove object
		if (gameObject.transform.position.z >= 100) Destroy(gameObject);
	}
	
	void FixedUpdate () {
        // for time elapsed = seconds. 
        // time cube root = timeElapsed. Round Down
        // time elpased * moveSpeed.




		gameObject.transform.position = Vector3.Lerp(gameObject.transform.position,
		                                             new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z + moveByPoints),
		                                             Time.deltaTime * speedMove);
	}
}
