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

    IEnumerator PerformActionEveryTwoSeconds()
    {
        while (true)
        {
            // Выполнение действия
            PerformAction();

            // Задержка на 2 секунды
            yield return new WaitForSeconds(2f);
        }
    }

    void PerformAction()
    {
        Instantiate(Asteroid, gameObject.transform);
    }
}
