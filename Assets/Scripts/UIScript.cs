using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    public static int minutes;
    public static int seconds;
    public static float miliSeconds;

    public Text minuteText;
    public Text secondText;
    public Text boosterText;

    void Update()
    {
        miliSeconds += Time.deltaTime * 10;
        if (miliSeconds >= 10){
            miliSeconds = 0;
            seconds += 1;
        }

        if (seconds <= 9){
            secondText.text = "0" + seconds;
        } else {
            secondText.text = seconds.ToString();
        }
        if (seconds >= 60){
            seconds = 0;
            minutes += 1;
        }
        if (minutes <= 9){
            minuteText.text = "0" + minutes + ":";
        } else {
            minuteText.text = minutes + ":";
        }
        boosterText.text = PlayerScript.boost.ToString("0");
    }
}
