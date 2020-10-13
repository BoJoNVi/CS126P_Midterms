using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{

    public Button playBtn, quitBtn;

    void Start(){
        playBtn.onClick.AddListener(play);
        quitBtn.onClick.AddListener(quit);
    }

    public void play(){
        SceneManager.LoadScene(1);
    }
    public void quit(){
        Application.Quit();
    }
}
