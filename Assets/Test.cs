using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update <-- 맨 처음 딱 한번 실행.
    void Start()
    {
        
    }

    // Update is called once per frame  <- 프래임마다 계속 실행. 매번 틱마다 실행.
    void Update()
    {
        transform.Rotate(new Vector3(1.0f, 1.0f, 1.0f));
    }
}
