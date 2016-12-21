using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartController : MonoBehaviour {

    Rigidbody2D rb;
    public int moveSpeed = 0;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        rb.velocity = new Vector2(moveSpeed, rb.velocity.y);
    }
}
