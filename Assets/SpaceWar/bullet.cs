using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class bullet : MonoBehaviour
{
    Vector3 vec;
    Rigidbody2D rb;
    Vector3 direction;
    void Start()
    {
        vec = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>().position;
        rb = GetComponent<Rigidbody2D>();
        direction = (vec - transform.position).normalized;
    }
    public float moveSpeed = 10f;
    void Update()
    {
        

        // Преобразовать направление в угол (в радианах)
        float angle = Mathf.Atan2(direction.y, direction.x);

        // Вычислить новое значение скорости для Rigidbody2D
        Vector2 newVelocity = new Vector2(Mathf.Cos(angle), Mathf.Sin(angle)) * moveSpeed;

        // Установить скорость Rigidbody2D
        rb.velocity = newVelocity;

        // Опционально: повернуть объект в направлении движения (если нужно)
        transform.rotation = Quaternion.Euler(0, 0, angle * Mathf.Rad2Deg);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            hp.hps -= 1;
            Destroy(gameObject);
        }
    }
}
