using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyer : MonoBehaviour {

	// Use this for initialization
void Update() {
        transform.Translate(Vector3.forward*-1 *5* Time.deltaTime);
        transform.Translate(Vector3.forward *5* Time.deltaTime);
    }
 void OnCollisionEnter (Collision col)
    {
        if(col.gameObject.tag == "Destroyable")
        {
            Destroy(col.gameObject);
        }
}
}