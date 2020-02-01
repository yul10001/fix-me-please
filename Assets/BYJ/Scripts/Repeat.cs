using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Repeat : MonoBehaviour
{

    int speed = 140;
    
    float fMove;

    IEnumerator coroutine;

    bool press;

    void Start()
    {
        coroutine = RotateCorutine();
        StartCoroutine(coroutine);
    }

    // Update is called once per frame
    void Update()
    {
        fMove = Time.deltaTime * speed;
        //transform.Rotate(Vector3.forward * fMove * -1);
        
        if(Input.GetKeyDown(KeyCode.B))
        {
            StopCoroutine(coroutine);
        }
        if(Input.GetKeyUp(KeyCode.B))
        {
            StartCoroutine(coroutine);
        }
    }

    IEnumerator RotateCorutine()
    {
        while(true)
        {
            transform.Rotate(Vector3.forward * fMove * -1);
            yield return new WaitForSeconds(0);
        }
        
    }
}
