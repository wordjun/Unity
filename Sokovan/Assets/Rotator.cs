﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(60 * Time.deltaTime, 60* Time.deltaTime, 60* Time.deltaTime);

        //Time.deltaTime은 화면이 한번 깜박이는 시간 = 한 프레임의 시간
        //화면이 60번 깜박이면 (초당 60프레임) 1/60
    }
}
