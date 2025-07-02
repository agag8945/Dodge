using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem; // Input System 패키지 사용

public class PlayerController : MonoBehaviour
{
    public Rigidbody playerRigidbody;
    public float speed = 8f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 게임 오브젝트에서 Rigidbody 컴포넌트를 찾아 playerRigidbody에 할당
        playerRigidbody = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        // if (Keyboard.current.upArrowKey.isPressed)
        // {
        //     // 위쪽 방향키 입력이 감지된 경우 z 방향 향하기
        //     playerRigidbody.AddForce(0f, 0f, speed);
        // }

        // if (Keyboard.current.downArrowKey.isPressed)
        // {
        //     // 아래쪽 방향키 입력이 감지된 경우 -z 방향 향하기
        //     playerRigidbody.AddForce(0f, 0f, -speed);
        // }

        // if (Keyboard.current.rightArrowKey.isPressed)
        // {
        //     // 오른쪽 방향키 입력이 감지된 경우 x 방향 향하기
        //     playerRigidbody.AddForce(speed, 0f, 0f);
        // }

        // if (Keyboard.current.leftArrowKey.isPressed)
        // {
        //     // 오른쪽 방향키 입력이 감지된 경우 -x 방향 향하기
        //     playerRigidbody.AddForce(-speed, 0f, 0f);
        // }

        // 수평과 수직 축 입력 값을 감지
        float xInput = Input.GetAxis("Horizontal");
        Debug.Log("xInput : " + xInput);
        float zInput = Input.GetAxis("Vertical");
        Debug.Log("zInput : " + zInput);

        // 실제 이동 속도를 입력 값과 이동 속력을 통해 결정
        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;

        // Vector3 속도를 (xSpeed, 0, zSpeed)로 설정
        Vector3 newVelocity = new Vector3(xSpeed, 0f, zSpeed);

        // Rigidbody의 속도에 newVelocity를 할당
        playerRigidbody.linearVelocity = newVelocity;
    }

    public void Die()
    {
        // 자신의 게임 오브젝트를 비활성화
        gameObject.SetActive(false);
        // 가져온 GameManager 오브젝트의 EndGame() 메서드 실행
        //gameObject.EndGame();
    }
}
