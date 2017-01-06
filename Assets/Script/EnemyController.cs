using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    float time = 0.0f;
    public float moveSpeed = 0;
    public int HeartRandom;
    public GameObject Heart;
    public float bombSpeed_x = 0.1f;
    public float bombSpeed_y = 0.1f;
    public GameObject boy;
    public GameObject girl;
    public GameObject Bomb;

    int y = -4;
    int x = 0;
    int i = 0;
    GameObject Enemy;
    HeartController heartController;

    int bomb = 1;

    // Use this for initialization
    void Start()
    {
        HeartRandom = Random.Range(1, 6);
        Debug.Log("ハートの数は" + 　HeartRandom);

        //heartController = GetComponent<HeartController>();
        // heartController.Hp = HeartRandom;
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
       /* if (bomb == 0)
        {
            Enemy = GameObject.Find("Enemy");
            Vector2 pos = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y + 2);
            Heart = (GameObject)Instantiate(Bomb, transform.position, Quaternion.identity);
            Heart.transform.parent = Enemy.transform;
            Destroy(this.gameObject);
            boy.transform.position += new Vector3(-bombSpeed_x, bombSpeed_y);
            girl.transform.position += new Vector3(bombSpeed_x, bombSpeed_y);
        }*/
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
