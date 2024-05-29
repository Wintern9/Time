using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner2 : MonoBehaviour
{
    public GameObject Asteroid;
    void Start()
    {
        // Запускаем корутину при старте
        StartCoroutine(PerformActionEveryTwoSeconds());
    }

    public float sec;

    IEnumerator PerformActionEveryTwoSeconds()
    {
        while (true)
        {
            // Выполнение действия
            PerformAction();

            if(sec == 0)
            {
                sec = 2;
            }
            // Задержка на 2 секунды
            yield return new WaitForSeconds(sec);
        }
    }

    void PerformAction()
    {
        GameObject obj = Instantiate(Asteroid, gameObject.transform);
        obj.transform.parent = null;
    }
}
