using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelect : MonoBehaviour
{
    // Start is called before the first frame update
    private bool firstPush = false; 

    /**
     * キャラ決定された時の処理
     */
    public void PressCharacter()
    {
        if (firstPush) {
            return;
        }
        firstPush = true;
        SceneManager.LoadScene("battleStart");
    }
}
