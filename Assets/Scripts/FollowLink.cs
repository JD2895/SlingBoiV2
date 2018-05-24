using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowLink : MonoBehaviour {
    public float distanceWanted;
    public GameObject previous_link;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 diff = transform.position - previous_link.transform.position;
        //diff.z = 0.0f; // ignore Y (as requested in question)
        transform.position = previous_link.transform.position + diff.normalized * distanceWanted;
    }
}
