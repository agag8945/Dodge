using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // UI 관련 라이브러리
using UnityEngine.SceneManagement; // 씬 관리 관련 라이브러리


public class GameManager : MonoBehaviour
{

    public GameObject gameoverText; // 게임 오버 시 활성화 할 텍스트 게임 오브젝트
    public Text timeText;           // 생존 시간을 표시할 텍스트 컴포넌트
    public Text recordText;        // 최고 기록을 표시할 텍스트 컴포넌트    

    private float surviveTime;      // 생존 시간
    private bool isGameOver;        // 게임 오버 상태

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 생존 시간과 게임 오버 상태 초기화
        surviveTime = 0;
        isGameOver = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        // 게임오버가 아닐 때
        if (!isGameOver)
        {
            // 생존 시간 갱신
            surviveTime += Time.deltaTime;

            // 갱신한 생존 시간을 timeText 텍스트 컴포넌트를 통해 표시
            timeText.text = "Time : " + (int)surviveTime;
        }

        else
        {
            // 게임 오버인 상태에서 키보드 R키를 누르면
            if (Input.GetKeyDown(KeyCode.R))
            {
                // 현재 씬 다시 로드
                SceneManager.LoadScene("Main");
            }
        }
        
    }

    public void EndGame()
    {
        
    }
}
