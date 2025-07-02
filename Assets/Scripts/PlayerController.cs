using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem; // Input System 패키지 사용

public class PlayerControler : MonoBehaviour
{
    public Rigidbody playerRigidbody;
    public float speed = 8f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 게임 오브젝트에서 Rigidbody 컴포넌트를 찾아 playerRigidbody에 할당
        // playerRigidbody = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.upArrowKey.isPressed)
        {
            // 위쪽 방향키 입력이 감지된 경우 z 방향 향하기
            playerRigidbody.AddForce(0f, 0f, speed);
        }

        if (Keyboard.current.downArrowKey.isPressed)
        {
            // 아래쪽 방향키 입력이 감지된 경우 -z 방향 향하기
            playerRigidbody.AddForce(0f, 0f, -speed);
        }

        if (Keyboard.current.rightArrowKey.isPressed)
        {
            // 오른쪽 방향키 입력이 감지된 경우 x 방향 향하기
            playerRigidbody.AddForce(speed, 0f, 0f);
        }

        if (Keyboard.current.leftArrowKey.isPressed)
        {
            // 오른쪽 방향키 입력이 감지된 경우 -x 방향 향하기
            playerRigidbody.AddForce(-speed, 0f, 0f);
        }
    }
}
