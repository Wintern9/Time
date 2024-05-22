using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner2 : MonoBehaviour
{
    public GameObject Asteroid;
    void Start()
    {
        // ��������� �������� ��� ������
        StartCoroutine(PerformActionEveryTwoSeconds());
    }

    IEnumerator PerformActionEveryTwoSeconds()
    {
        while (true)
        {
            // ���������� ��������
            PerformAction();

            // �������� �� 2 �������
            yield return new WaitForSeconds(2f);
        }
    }

    void PerformAction()
    {
        Instantiate(Asteroid, gameObject.transform);
    }
}
