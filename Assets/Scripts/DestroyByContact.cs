using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D other)
    {
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
