using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class hp : MonoBehaviour
{
    static public int hps = 10;

    Scrollbar scrollbar;
    void Start()
    {
        scrollbar = GetComponent<Scrollbar>();
    }

    void Update()
    {
        scrollbar.size = float.Parse((hps/10f).ToString());

        if(hps <= 0)
        {
            hps = 10;
            Scene currentScene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(currentScene.name);
        }
    }
}
