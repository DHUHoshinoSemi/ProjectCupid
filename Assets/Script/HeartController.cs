using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartController : MonoBehaviour
{

    //Rigidbody2D rb;

    public float upSpeed = 0;
    public GameObject heartRed;
    public GameObject heartYellow;
    public int Hp = 0;
    public float life = 1.0f;
    public double disappearPoint = 7.3;


    private Vector2 m_pos;


    // Use this for initialization
    void Start()
    {

        //rb = GetComponent<Rigidbody2D>();

        m_pos = transform.localPosition;
        heartRed.SetActive(true);
        heartYellow.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition = m_pos;
        m_pos.y += upSpeed;
        life -= Time.deltaTime;

        StartCoroutine("heartMove");

        if (m_pos.y >= disappearPoint)
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
            //Hp -= 1;
            Debug.Log("hit Arrow");
            Debug.Log(Hp);
            heartRed.SetActive(false);
            heartYellow.SetActive(true);
        }
    }
}
