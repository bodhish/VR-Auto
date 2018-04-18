using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadCreator : MonoBehaviour {

	public GameObject road;

	void Start() {
    for (int i = 0; i < 5; i++) {
        Instantiate(road);
    }
}
}
