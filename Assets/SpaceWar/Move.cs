using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Vector3 move;
    Vector3 clickPos;
    public Camera mainCamera;

    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        clickPos = transform.position;
    }

    void Update()
    {
        Vector3 mousePosition = Input.mousePosition - new Vector3(Screen.width /2, Screen.height/2, 0) ;

        if(mousePosition.x != float.PositiveInfinity)
            rb.MovePosition(mousePosition / 10f);
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("asteroid"))
        {
            hp.hps -= 10;
        }
    }
}
