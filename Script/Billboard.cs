using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//메인카메라와 나의 회전 방향을 일치시킨다.
// -> 빌보드 라고 한다.
public class Billboard : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Camera.main.transform.rotation;

    }
}