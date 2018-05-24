using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeekPlayer : MonoBehaviour {

    public GameObject player_obj;
    public float movespeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //transform.LookAt(player_obj.transform);
        //transform.position += transform.forward * movespeed * Time.deltaTime;

        Vector3 diff = transform.position - player_obj.transform.position;
        transform.position = transform.position - diff.normalized * movespeed;
    }
}
