using UnityEngine;
using System.Collections;

public class TreeGenerator : MonoBehaviour {
	
	public float timeToGenerateObject;

	public GameObject objectToGenerate1L;
	public GameObject objectToGenerate2L;
	public GameObject objectToGenerate3L;

	public GameObject objectToGenerate1R;
	public GameObject objectToGenerate2R;
	public GameObject objectToGenerate3R;
	
	void Start () {
		InvokeRepeating("Generate", 0f, timeToGenerateObject);
	}
	
	void Generate () {
		int objectToGenerateL = Random.Range(0, 3);
		int objectToGenerateR = Random.Range(0, 3);
		GameObject objectForGenerateL;
		GameObject objectForGenerateR;
		
		if (objectToGenerateL == 0) { objectForGenerateL = objectToGenerate1L;}
		else if (objectToGenerateL == 1) { objectForGenerateL = objectToGenerate2L;}
		else { objectForGenerateL = objectToGenerate3L;}
		
		if (objectToGenerateR == 0) { objectForGenerateR = objectToGenerate1R;}
		else if (objectToGenerateR == 1) { objectForGenerateR = objectToGenerate2R;}
		else { objectForGenerateR = objectToGenerate3R;}

		Instantiate(objectForGenerateL);
		Instantiate(objectForGenerateR);
	}
}
