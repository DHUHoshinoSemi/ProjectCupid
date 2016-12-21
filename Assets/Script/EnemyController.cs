using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    Rigidbody2D rb;
    int HeartRandom = Random.Range(1, 6);
    int i = 0;
    GameObject Enemy;

    public int moveSpeed = 0;
    public GameObject Heart;



    // Use this for initialization
    void Start () {
        Debug.Log(HeartRandom);

        rb = GetComponent<Rigidbody2D>();
        Enemy = GameObject.Find("Enemy");
        Vector2 pos = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y + 2);

        for (i = 0; i < HeartRandom; i++)
        {
            //Instantiate(Heart);
            Heart = (GameObject)Instantiate(Heart, transform.position, Quaternion.identity);
            Heart.transform.parent = Enemy.transform;
        }
    }
	
	// Update is called once per frame
	void Update () {
        rb.velocity = new Vector2(-moveSpeed, rb.velocity.y);
    }
}
