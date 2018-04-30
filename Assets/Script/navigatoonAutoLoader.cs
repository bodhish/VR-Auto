using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class navigatoonAutoLoader : MonoBehaviour {

	public GameObject nav;

	
	void Start() {
    InvokeRepeating( "NavMaker", 10f, 10f );
	}
	void NavMaker(){
	  Instantiate(nav);
    }

}
