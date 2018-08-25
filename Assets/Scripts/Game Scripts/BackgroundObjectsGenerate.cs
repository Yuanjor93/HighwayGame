using UnityEngine;
using System.Collections;

public class BackgroundObjectsGenerate : MonoBehaviour {
	
	public float timeToGenerateObject;
	public GameObject objectToGenerate1L;
	public GameObject objectToGenerate2L;
	public GameObject objectToGenerate3L;
	public GameObject objectToGenerate4L;
	public GameObject objectToGenerate5L;
	public GameObject objectToGenerate6L;
	public GameObject objectToGenerate7L;
	public GameObject objectToGenerate8L;
	public GameObject objectToGenerate9L;
	
	public GameObject objectToGenerate1R;
	public GameObject objectToGenerate2R;
	public GameObject objectToGenerate3R;
	public GameObject objectToGenerate4R;
	public GameObject objectToGenerate5R;
	public GameObject objectToGenerate6R;
	public GameObject objectToGenerate7R;
	public GameObject objectToGenerate8R;
	public GameObject objectToGenerate9R;
	
	void Start () {
		InvokeRepeating("Generate", 0f, timeToGenerateObject);
	}
	
	void Generate () {
		int objectToGenerateL = Random.Range(0, 9);
		int objectToGenerateR = Random.Range(0, 9);
		GameObject objectForGenerateL;
		GameObject objectForGenerateR;
		
		if (objectToGenerateL == 0) { objectForGenerateL = objectToGenerate1L;}
		else if (objectToGenerateL == 1) { objectForGenerateL = objectToGenerate2L;}
		else if (objectToGenerateL == 2) { objectForGenerateL = objectToGenerate3L;}
		else if (objectToGenerateL == 3) { objectForGenerateL = objectToGenerate4L;}
		else if (objectToGenerateL == 4) { objectForGenerateL = objectToGenerate5L;}
		else if (objectToGenerateL == 5) { objectForGenerateL = objectToGenerate6L;}
		else if (objectToGenerateL == 6) { objectForGenerateL = objectToGenerate7L;}
		else if (objectToGenerateL == 7) { objectForGenerateL = objectToGenerate8L;}
		else { objectForGenerateL = objectToGenerate9L;}
		
		if (objectToGenerateR == 0) { objectForGenerateR = objectToGenerate1R;}
		else if (objectToGenerateR == 1) { objectForGenerateR = objectToGenerate2R;}
		else if (objectToGenerateR == 2) { objectForGenerateR = objectToGenerate3R;}
		else if (objectToGenerateR == 3) { objectForGenerateR = objectToGenerate4R;}
		else if (objectToGenerateR == 4) { objectForGenerateR = objectToGenerate5R;}
		else if (objectToGenerateR == 5) { objectForGenerateR = objectToGenerate6R;}
		else if (objectToGenerateR == 6) { objectForGenerateR = objectToGenerate7R;}
		else if (objectToGenerateR == 7) { objectForGenerateR = objectToGenerate8R;}
		else { objectForGenerateR = objectToGenerate9R;}

		Instantiate(objectForGenerateL);
		Instantiate(objectForGenerateR);
	}
}
