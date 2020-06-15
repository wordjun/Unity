using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

//camelcase(카멜명명법)
public class Player : MonoBehaviour
{
    public GameManager gameManager;
    public float speed = 10f;
    private Rigidbody playerRigidbody;

    //게임이 처음 시작됐을 때 한번 수행
    void Start()
    {
        //유저입력을 받는다
        playerRigidbody = GetComponent<Rigidbody>();
    }

    //화면 한번 깜빡일때마다 수행되는 함수
    //거의 real-time수행이라 볼 수 있다 (갱신함수)
    //1초에 대략 60번(depends on computer specs)
    void Update()
    {
        if(gameManager.isGameOver == true){
            return;
        }
        // //user input
        // //만약 이 함수가 발동되고 있을 때 사용자가 해당키를 누르지 않고 있다면 false를 반환
        // if(Input.GetKey(KeyCode.W)){//W키를 누르고 있는 동안엔 z방향으로 speed속도만큼 이동
        //     playerRigidbody.AddForce(0, 0, speed);//x는 옆, y는 위, z는 앞/뒤
        // }
        // if(Input.GetKey(KeyCode.A)){//왼쪽으로 가는 키
        //     playerRigidbody.AddForce(-speed, 0, 0);
        // }
        // if(Input.GetKey(KeyCode.S)){//뒤쪽으로 가는 키
        //     playerRigidbody.AddForce(0, 0, -speed);
        // }
        // if(Input.GetKey(KeyCode.D)){//오른쪽으로 가는 키
        //     playerRigidbody.AddForce(speed, 0, 0);
        // }

        //-1 ~ 1
        // A ~ D
        //조이스틱을 왼쪽이나 오른쪽으로 살살밀면 -0.5, 0.2 등이 나온다
        float inputX = Input.GetAxis("Horizontal");

        //발사기능 - "Fire" -마우스 왼쪽버튼
        float inputZ = Input.GetAxis("Vertical");
        //playerRigidbody.AddForce(inputX * speed, 0, inputZ * speed);
        
        float fallSpeed = playerRigidbody.velocity.y;//y의 속도

        //Vector3는 x, y, z를 지정해준다.
        Vector3 velocity = new Vector3 (inputX, 0, inputZ);
        velocity *= speed;//x, y, z에 각각 speed곱해줌
        velocity.y = fallSpeed;
        //(inputX * speed)
        //속도를 바로 덮어씌우기때문에 관성없이 움직인다
        playerRigidbody.velocity = velocity;

    }
}
