using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laserShot : MonoBehaviour
{
    Rigidbody2D rg;
    [SerializeField]private float speed;

    void Start()
    {
        rg = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rg.velocity = new Vector3(0, 1,0) * speed;
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
