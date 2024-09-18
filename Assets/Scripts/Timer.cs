using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timerlbl;
    public float timer = 10f;
    // Start is called before the first frame update


    private void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            DisplayTime(timer);
        }
        else
        {
            Trainer.gameOver = true;
            timerlbl.text = "Game Over";
        }
    }
    public void DisplayTime(float displayTime)
    {
        float minutes = Mathf.FloorToInt(displayTime / 60);
        float seconds = Mathf.FloorToInt(displayTime % 60);
        timerlbl.text = $"{minutes}:{seconds}";
    }


    // Update is called once per frame

}
