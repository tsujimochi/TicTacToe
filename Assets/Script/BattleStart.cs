using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BattleStart : MonoBehaviour
{
    // Start is called before the first frame update
    private bool firstPush = false; 

    /**
     * 対戦開始ボタンが押下された時の処理
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
