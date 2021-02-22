using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Credit : MonoBehaviour
{
    private bool firstPush = false; 

    /**
     * タイトルへボタンが押下された時の処理
     */
    public void PressTitle()
    {
        if (firstPush) {
            return;
        }
        firstPush = true;
        SceneManager.LoadScene("title");
    }
}
