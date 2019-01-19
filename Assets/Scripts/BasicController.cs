using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicController : MonoBehaviour {

		// Update is called once per frame
	void Update () {
        Debug.Log("Horizontal Input =" + Input.GetAxis("Horizontal"));
	}
}
