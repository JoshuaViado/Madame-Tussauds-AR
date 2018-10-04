using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class test : MonoBehaviour {

	Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
	

	void start() {
		if(Physics.Raycast(ray, 100)) {
			print("Si le jue");
		}

		
	}


}
		

