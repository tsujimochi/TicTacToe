using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Battle : MonoBehaviour
{
    // Start is called before the first frame update
    private bool firstPush = false; 

    /**
     * 対戦終了時の処理
     */
    public void EndBattle()
    {
        if (firstPush) {
            return;
        }
        firstPush = true;
        SceneManager.LoadScene("battleResult");
    }

    /**
     * キャラクター選択に戻る時の処理
     */
    public void PressCharacterSelect()
    {
        if (firstPush) {
            return;
        }
        firstPush = true;
        SceneManager.LoadScene("characterSelect");
    }

    /**
     * 最初からやりなおす
     */
    public void ReStart()
    {
        if (firstPush) {
            return;
        }
        firstPush = true;
        SceneManager.LoadScene("battle");
    }
}
