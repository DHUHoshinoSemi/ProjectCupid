using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartController : MonoBehaviour {

    Rigidbody2D rb;

    public float upSpeed = 0;

    private Vector2 m_pos;

    private GameObject hGameObject;

    // Use this for initialization
    void Start () {
        hGameObject = GameObject.Find("Heart");

        rb = GetComponent<Rigidbody2D>();

        m_pos = transform.localPosition;
    }

    // Update is called once per frame
    void Update () {
        transform.localPosition = m_pos;
        m_pos.y += upSpeed;

        StartCoroutine("heartMove");
    }

    private IEnumerator heartMove()
    {
        while (true)
        {
            m_pos.x += upSpeed * 2;
            yield return new WaitForSeconds(2.0f);
            m_pos.x -= upSpeed * 2;
            yield return new WaitForSeconds(2.0f);
        }
    }
}
