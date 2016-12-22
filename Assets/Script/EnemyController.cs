using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    float time = 0.0f;
    public float moveSpeed = 0;
    public GameObject Heart;

    float y = -4;
    int x = 0;
    int HeartRandom = Random.Range(1, 6);
    int i = 0;

    GameObject Enemy;

    // Use this for initialization
    void Start()
    {
        Debug.Log(HeartRandom);
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 v = new Vector2(transform.position.x - moveSpeed * Time.deltaTime, transform.position.y);
        transform.position = v;

        time = time + Time.deltaTime;
        if (x < 1){
            if (time >= 2.0f)
            {
                StartCoroutine("heartAppear");
                x++;
            }
        }
    }

    private IEnumerator heartAppear()
    {
            Enemy = GameObject.Find("Enemy");
            Vector2 pos = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y + 2);

            for (i = 0; i < HeartRandom; i++)
            {
                float waitTime = Random.Range(1.5f, 3.0f);
                Debug.Log(waitTime);
                Heart = (GameObject)Instantiate(Heart, transform.position, Quaternion.identity);
                Heart.transform.parent = Enemy.transform;
                yield return new WaitForSeconds(waitTime);
            }
        }
}
