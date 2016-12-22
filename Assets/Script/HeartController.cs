using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartController : MonoBehaviour
{

    Rigidbody2D rb;

    public float upSpeed = 0;
    public GameObject heartRed;
    public GameObject heartYellow;

    private Vector2 m_pos;


    // Use this for initialization
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();

        m_pos = transform.localPosition;
        heartRed.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition = m_pos;
        m_pos.y += upSpeed;

        StartCoroutine("heartMove");

        if (m_pos.y >= 7.3)
        {
            Destroy(this.gameObject);
        }
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

    void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.tag == "Arrow")
        {
            Debug.Log("hit Arrow");
            heartRed.SetActive(false);
            heartYellow.SetActive(true);
        }
    }
}
