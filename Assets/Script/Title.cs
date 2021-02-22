using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{
    private bool firstPush = false; 

    /**
     * スタートボタンが押下された時の処理
     */
    public void PressStart()
    {
        if (firstPush) {
            return;
        }
        firstPush = true;
        SceneManager.LoadScene("characterSelect");
    }

    /**
     * クレジットボタンが押下された時の処理
     */
    public void PressCredit()
    {
        if (firstPush) {
            return;
        }
        firstPush = true;
        SceneManager.LoadScene("credit");  
    }
}
