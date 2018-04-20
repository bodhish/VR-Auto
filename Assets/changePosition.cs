using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changePosition : MonoBehaviour
{
	public GameObject target;
    // Define methord for changing position
    void start()
    {
    target = GameObject.Find("Auto");
    }
    
	public void GoToPositionOne()
    {
        Debug.Log("My Methord was called 1 ");
        target.transform.position = new Vector3(-7.2f, 1.92f, 1.27f);
    }
    public void GoToPositionTwo()
    {
        Debug.Log("My Methord was called 2");
		target.transform.position = new Vector3(-3.1f, 1.92f, 1.27f);
    }
    public void GoToPositionThree()
    {
        Debug.Log("My Methord was called 3");
		target.transform.position = new Vector3(2.5f, 1.92f, 1.27f);
    }
    public void GoToPositionFour()
    {
        Debug.Log("My Methord was called 4");
		target.transform.position = new Vector3(6.7f, 1.92f, 1.27f);
    }

}
