using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour {

    public float rorateSpeed = 5.0f;

    // Use this for initialization
    void Start () {
		
	}


    void FixedUpdate()
    {
        float r = Input.GetAxis("Rotate");
        transform.Rotate(new Vector3(0, 0, 1), r * Time.deltaTime * rorateSpeed);
    }
}
