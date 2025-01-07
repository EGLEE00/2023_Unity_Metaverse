
/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] float remainingTime;


    // Update is called once per frame
    void Update()
    {
        if (remainingTime > 0)
        {
            remainingTime -= Time.deltaTime;
        }
        else if (remainingTime < 0)
        {
            remainingTime = 0;
            GameOver();
            timerText.color = Color.red;

        }

        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);
        timerText.text = string.Format("{0:00} : {1:00}", minutes, seconds);
    }

    void GameOver()
    {

    }
}
*/
   
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] float remainingTime;
    public GameObject gameOverPopup; // 팝업 UI 오브젝트를 Inspector에서 할당해야 함

    bool isGameOver = false;
    //bool isRestart = false;

    void Update()
    {
        if (!isGameOver && remainingTime > 0)
        {
            remainingTime = Mathf.Max(remainingTime - Time.deltaTime, 0);
        }
        else if (!isGameOver)
        {
            remainingTime = 0;
            GameOver();
        }

        int minutes = Mathf.FloorToInt(Mathf.Max(remainingTime / 60, 0));
        int seconds = Mathf.FloorToInt(Mathf.Max(remainingTime % 60, 0));
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    void GameOver()
    {
        isGameOver = true;
        timerText.color = Color.red;
        // 여기서 게임 오버 팝업을 띄워줍니다.
        if (gameOverPopup != null)
        {
            gameOverPopup.SetActive(true); // 팝업을 활성화하여 보이게 함
            // 게임 오버 팝업을 보여주는 애니메이션 등을 추가할 수 있습니다.
        }
    }

    /*
    void Restart()
    {
        isRestart = true;
        
    }
    */
}

