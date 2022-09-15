using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRigidbody;
    public float speed = 8f; // 이동 속력
    
    void Start()
    {
        // 게임 오브젝트에서 Rigidbody 컴포넌트를 찾아서
        // playerRigidbody(변수)에 할당
        GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) == true)
        {
            //위쪽 방향키 입력이 감지된 경우 z 방향 힘 주기
            playerRigidbody.AddForce(0f, 0f, speed);
        }

        if (Input.GetKey(KeyCode.DownArrow) == true)
        {
            // 아래쪽 방향키 입력이 감지된 경우 -z 방향 힘 주기
            playerRigidbody.AddForce(0f, 0f, -speed);
        }

        if (Input.GetKey(KeyCode.RightArrow) == true)
        {
            // 오른쪽 방향키 입력이 감지된 경우 x 방향 힘 주기
            playerRigidbody.AddForce(speed, 0f, 0f);
        }

        if (Input.GetKey(KeyCode.LeftArrow) == true)
        {
            // 왼쪽 방향키 입력이 감지된 경우 -x 방향 힘 주기
            playerRigidbody.AddForce(-speed, 0f, 0f);
        }

    }

    public void Die()
    {
        //자신의 게임 오브젝트를 비활성화
        gameObject.SetActive(false);
    }


}
