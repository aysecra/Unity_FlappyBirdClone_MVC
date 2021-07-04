using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    public void onBtnPlayClicked()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void onBtnMenuClicked(){
        SceneManager.LoadScene("MenuScene");
    }
}
