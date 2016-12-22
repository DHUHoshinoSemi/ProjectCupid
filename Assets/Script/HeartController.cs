using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartController : MonoBehaviour {

    Rigidbody2D rb;

    public float upSpeed = 0;

    private Vector2 m_pos;

    // Use this for initialization
    void Start () {
        m_pos = transform.localPosition;

    }
	
	// Update is called once per frame
	void Update () {
        transform.localPosition = m_pos;
        m_pos.y += upSpeed;
    }
}
