using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadCreator : MonoBehaviour {

	public GameObject road;

	
	void Start() {
    InvokeRepeating( "RoadMaker", 4f, 4f );
	}
	void RoadMaker(){
	  Instantiate(road);
    }
}
