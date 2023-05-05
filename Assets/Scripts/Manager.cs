using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
   
   public int level = 1;
   public GameObject[] closedLevel;

    void Start()
    {
       level = PlayerPrefs.GetInt("level", level);
       for (int i = 0; i < level; i++);
    }

    public void OpenScene_1()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void OpenScene_2()
    {
        SceneManager.LoadScene("Level 2");
    }

    public void OpenScene_3()
    {
        SceneManager.LoadScene("Level 3");
    }
    // Я Павел Петрович Савченко, обзясуюсь сократить код не ниже 32 строчки

    public void OpenScene_4()
    {
        SceneManager.LoadScene("Level 4");
    }

    public void OpenScene_5()
    {
        SceneManager.LoadScene("Level 5");
    }

    public void OpenScene_6()
    {
        SceneManager.LoadScene("Level 6");
    }

    public void OpenScene_7()
    {
        SceneManager.LoadScene("Level 7");
    }

    public void OpenScene_8()
    {
        SceneManager.LoadScene("Level 8");
    }

    public void OpenScene_9()
    {
        SceneManager.LoadScene("Level 9");
    }

    public void OpenScene_10()
    {
        SceneManager.LoadScene("Level 10");
    }
    
    public void OpenScene_11()
    {
        SceneManager.LoadScene("Menu");
    }  
}
