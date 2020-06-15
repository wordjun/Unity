using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour
{
    public bool isOverlapped = false;
    private Renderer myRenderer;
    public Color touchColor;
    private Color originalColor;
    // Start is called before the first frame update
    void Start()
    {
        myRenderer = GetComponent<Renderer>();
        originalColor = myRenderer.material.color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //trigger인 collider와 충돌할때 자동으로 실행
    //Enter 충돌을 한 그 순간
    void OnTriggerEnter(Collider other){
        if(other.tag == "EndPoint"){
            isOverlapped = true;
            myRenderer.material.color = touchColor;
        }
        
    }

    //일반 콜라이더와 충돌 시 자동으로 실행
    //exit는 붙었다가 떼어질 때
    void OnTriggerExit(Collider other){
        if(other.tag == "EndPoint"){
            isOverlapped = false;
            myRenderer.material.color = originalColor;
        }
    }

    void OnTriggerStay(Collider other){
        if(other.tag == "EndPoint"){
            isOverlapped = true;
            myRenderer.material.color = touchColor;
        }
    }
}
