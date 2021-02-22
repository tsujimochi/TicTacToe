using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BattleResult : MonoBehaviour
{
    // Start is called before the first frame update
    private bool firstPush = false; 

    /**
     * タイトルへ戻る処理
     */
    public void PressTitle()
    {
        if (firstPush) {
            return;
        }
        firstPush = true;
        SceneManager.LoadScene("title");
    }

    /**
     * 対戦をやりなおす
     */
    public void PressBattle()
    {
        if (firstPush) {
            return;
        }
        firstPush = true;
        SceneManager.LoadScene("battle");
    }
}
