using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{

    int speed = 200;

    public void StartClickButton()
    {
        Debug.Log("Start");
  
        StartCoroutine(MoveCourtine());
        //StartCoroutine(LoadSceneCourtine());
        
    }

    IEnumerator LoadSceneCourtine()
    {
        yield return new WaitForSeconds(0.1f);
        SceneManager.LoadScene("Game");
    }

    IEnumerator MoveCourtine()
    {
        while(true)
        {
            if(transform.position.y < 1040)
            {
                transform.localPosition += Vector3.up * Time.deltaTime * speed;
            }
            
            yield return new WaitForSeconds(0);
        }
        
    }
}
