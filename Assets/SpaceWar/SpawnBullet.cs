using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBullet : MonoBehaviour
{
    public GameObject bullet; // Public reference to the bullet prefab

    void Start()
    {
        // No transform caching needed here (explained below)
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject newObject = Instantiate(bullet, gameObject.transform.position, transform.rotation);
            // newObject.transform.parent = null; // Uncomment if necessary
        }
    }
}
