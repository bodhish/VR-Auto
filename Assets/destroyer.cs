using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyer : MonoBehaviour {

	// Use this for initialization
	
 void OnCollisionEnter (Collision col)
    {
			Debug.Log("Game over");
            Destroy(col.gameObject);
    }
}
