using UnityEngine;
using System.Collections;

public class makeBuildings : MonoBehaviour {

	public Transform mycube; //assign in inspector
	public Transform mycylinder;
	public Transform mycapsule;
	public Transform mysphere;
	
	// Use this for initialization
	void Start () {
		StartCoroutine (buildings () );
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.R)){
			Application.LoadLevel(0); //or whatever number scene is
		}

	}

	IEnumerator buildings (){
		int totalObjects = 0;
		int counter = 0;
		int incrementX = 0;
		int incrementZ = 0;

		
		while (totalObjects < 300) {
			float pickOne = Random.Range (0f, 20f);
			if(pickOne < 5f){
				Instantiate (mycube, new Vector3 (0F + incrementX, 0F, 0F + incrementZ), Quaternion.identity);
			}
			else if (pickOne < 10){
				Instantiate (mycapsule, new Vector3 (0F + incrementX, 0F, 0F + incrementZ), Quaternion.identity);
			}
			else if(pickOne < 15){
				Instantiate (mysphere, new Vector3 (0F + incrementX, 0F, 0F + incrementZ), Quaternion.identity);
			}
			else {
				Instantiate (mycylinder, new Vector3 (0F + incrementX, 0F, 0F + incrementZ), Quaternion.identity);
			}


			counter++;
			totalObjects++;
			incrementX += 2;

			if (counter == 20){
				incrementZ += 2;
				incrementX = 0;
				counter = 0;
			}

			yield return new WaitForSeconds(0.1f);
		}
	}
}
