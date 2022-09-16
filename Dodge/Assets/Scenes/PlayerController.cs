using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRigidbody;
    public float speed = 8f; // �̵� �ӷ�
    
    void Start()
    {
        // ���� ������Ʈ���� Rigidbody ������Ʈ�� ã�Ƽ�
        // playerRigidbody(����)�� �Ҵ�
        playerRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey (KeyCode.UpArrow) == true)
        {
            playerRigidbody.AddForce(0f, 0f, speed);

        }
    }

    public void Die()
    {
        //�ڽ��� ���� ������Ʈ�� ��Ȱ��ȭ
        gameObject.SetActive(false);
    }


}
