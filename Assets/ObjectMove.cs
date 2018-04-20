using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMove : MonoBehaviour {

	// Use this for initialization
void Update() {
        transform.Translate(Vector3.forward*-1 *12* Time.deltaTime);
       // transform.Translate(Vector3.left * Time.deltaTime, Space.World);
    }
}
