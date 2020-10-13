using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FinishLineMenuScript : MonoBehaviour
{
    public Button playAgainBtn, quitBtn;
    public Text placingText;

    void Start(){
        playAgainBtn.onClick.AddListener(playAgain);
        quitBtn.onClick.AddListener(quit);
    }

    public void playAgain(){
        SceneManager.LoadScene(1);
    }
    public void quit(){
        Application.Quit();
    }
    public void placement(){
        if (PlayerScript.place == 1){
            placingText.text = PlayerScript.place.ToString() + "ST PLACE";
        }
        else if (PlayerScript.place == 2){
            placingText.text = PlayerScript.place.ToString() + "ND PLACE";
        }
        else if (PlayerScript.place == 3){
            placingText.text = PlayerScript.place.ToString() + "RD PLACE";
        }
        else if (PlayerScript.place == 4){
            placingText.text = PlayerScript.place.ToString() + "TH PLACE";
        }
    }
    void Update(){
        placement();
    }
}
