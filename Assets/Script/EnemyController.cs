using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    public float moveSpeed = 0;
    public GameObject Heart;

    float y = -4;

    Rigidbody2D rb;
    int HeartRandom = Random.Range(2, 6);
    int i = 0;
    
    GameObject Enemy;

    // Use this for initialization
    void Start()
    {
        Debug.Log(HeartRandom);

        StartCoroutine("heartAppear");
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 v = new Vector2(transform.position.x - moveSpeed * Time.deltaTime, transform.position.y);
        transform.position = v;
    }

    private IEnumerator heartAppear()
    {
        Enemy = GameObject.Find("Enemy");
        Vector2 pos = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y + 2);

        for (i = 0; i < HeartRandom; i++)
        {
            float waitTime = Random.Range(1.5f, 5.0f);
            Debug.Log(waitTime);
            Heart = (GameObject)Instantiate(Heart, transform.position, Quaternion.identity);
            Heart.transform.parent = Enemy.transform;
            yield return new WaitForSeconds(waitTime);
        }
    }
}
