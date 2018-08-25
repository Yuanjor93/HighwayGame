using UnityEngine;
using System.Collections;

public class EnemysGenerator : MonoBehaviour {

	public float lineLeftPosition;
	public float lineCentralPosition;
	public float lineRightPosition;
	
	public float timeToGenerateObject;
	public GameObject objectToGenerate1;
	public GameObject objectToGenerate2;
	public GameObject objectToGenerate3;
	public GameObject objectToGenerate4;
	public GameObject objectToGenerate5;
	public GameObject objectToGenerate6;
	public GameObject objectToGenerate7;
	public GameObject objectToGenerate8;
	public GameObject objectToGenerate9;
	
	void Start () {
		InvokeRepeating("Generate", 0f, timeToGenerateObject);
	}
	
	void Generate () {
		int objectToGenerate = Random.Range(0, 9);
		GameObject objectForGenerate;
		
		int positionToGenerate = Random.Range(0, 3);
		Vector3 positionForGenerate;
        //if(objectToGenerate >= 0 && objectToGenerate <= 9){

        //    objectForGenerate = objectToGenerate[objectToGenerate];
        //}

		if (objectToGenerate == 0) 
        { objectForGenerate = objectToGenerate1;
        }
		else if (objectToGenerate == 1) { objectForGenerate = objectToGenerate2;}
		else if (objectToGenerate == 2) { objectForGenerate = objectToGenerate3;}
		else if (objectToGenerate == 3) { objectForGenerate = objectToGenerate4;}
		else if (objectToGenerate == 4) { objectForGenerate = objectToGenerate5;}
		else if (objectToGenerate == 5) { objectForGenerate = objectToGenerate6;}
		else if (objectToGenerate == 6) { objectForGenerate = objectToGenerate7;}
		else if (objectToGenerate == 7) { objectForGenerate = objectToGenerate8;}
		else { objectForGenerate = objectToGenerate9;}

		if (positionToGenerate == 0) { 
			positionForGenerate  = new Vector3(lineLeftPosition, 
			                                   objectForGenerate.transform.position.y, 
			                                   objectForGenerate.transform.position.z);
		}
		else if (positionToGenerate == 1) {
			positionForGenerate  = new Vector3(lineCentralPosition, 
			                                   objectForGenerate.transform.position.y, 
			                                   objectForGenerate.transform.position.z);
		}
		else {
			positionForGenerate  = new Vector3(lineRightPosition, 
			                                   objectForGenerate.transform.position.y, 
			                                   objectForGenerate.transform.position.z);
		}

		objectForGenerate.transform.position = positionForGenerate;
		Instantiate(objectForGenerate);
	}
}
