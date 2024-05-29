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

    public float sec;

    IEnumerator PerformActionEveryTwoSeconds()
    {
        while (true)
        {
            // ���������� ��������
            PerformAction();

            if(sec == 0)
            {
                sec = 2;
            }
            // �������� �� 2 �������
            yield return new WaitForSeconds(sec);
        }
    }

    void PerformAction()
    {
        GameObject obj = Instantiate(Asteroid, gameObject.transform);
        obj.transform.parent = null;
    }
}
