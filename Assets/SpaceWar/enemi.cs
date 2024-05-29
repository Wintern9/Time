using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class enemi : MonoBehaviour
{
    Vector3[] vect3s = new Vector3[2]; 

    Rigidbody2D rb;
    
    void Start()
    {
        InvokeRepeating("Move", 0, 2);
        InvokeRepeating("bullet", 0, 3);
        GameObject[] gameObject = GameObject.FindGameObjectsWithTag("enemi");
        vect3s[0] = gameObject[0].transform.position;
        vect3s[1] = gameObject[1].transform.position;
        rb = GetComponent<Rigidbody2D>();
        xMove = Random.Range(vect3s[1].x, vect3s[0].x);
    }

    float xMove = 0;

    void Update()
    {

        Vector3 pos = rb.position;
        pos.x = xMove;
        Vector3 smoothPosition = Vector3.Lerp(rb.position, pos, moveSpeed * Time.fixedDeltaTime);
        Debug.Log($"{smoothPosition.x} + {smoothPosition.y}");
        smoothPosition.z = 0;
        rb.MovePosition(smoothPosition);
        
    }
    public float moveSpeed;
    void Move()
    {
        xMove = Random.Range(vect3s[1].x, vect3s[0].x);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("laser"))
        {
            Destroy(gameObject);
        }
    }
    public GameObject bullet1;
    public GameObject target;
    private void bullet()
    {
        GameObject obj = Instantiate(bullet1, target.transform.position, new Quaternion());
        obj.transform.parent = null;
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
