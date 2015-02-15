using UnityEngine;
using System.Collections;

public class Char : MonoBehaviour {
	
	public float speed=0.3f;
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey("left")){
			MoveLeft();
		}
		
		else if(Input.GetKey("right")){
			MoveRight();
		}
		else {
			Standby();
		}
	}

	void MoveRight(){
		gameObject.transform.Translate(new Vector3(speed,0,0));
		gameObject.GetComponent<Animator>().SetBool("Walk",true);
		gameObject.transform.rotation=Quaternion.Euler(0,0,0);
		print ("right");
	}
	
	void MoveLeft(){
		gameObject.transform.Translate(new Vector3(speed,0,0));
		gameObject.GetComponent<Animator>().SetBool("Walk",true);
		gameObject.transform.rotation=Quaternion.Euler(0,-180,0);
		print ("left");
	}	

	void Standby(){
		gameObject.GetComponent<Animator>().SetBool("Walk",false);
	}
}