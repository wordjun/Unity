using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject winUI;
    public ItemBox[] itemBoxes;
    public bool isGameOver;
    // Start is called before the first frame update
    void Start()
    {
        isGameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        //scene 재시작
        if(Input.GetKeyDown(KeyCode.Space)){
            SceneManager.LoadScene(0);
        }

        if(isGameOver == true){
            return;
        }
        int count = 0;
        for(int i = 0;i<3;i++){
            if(itemBoxes[i].isOverlapped == true){
                count++;
            }
        }
        if(count == 3){
            Debug.Log("GAME OVER");
            isGameOver = true;
            winUI.SetActive(true);
        }
    }
}
