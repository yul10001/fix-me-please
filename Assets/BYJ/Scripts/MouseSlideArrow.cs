using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseSlideArrow : MonoBehaviour
{

    Vector2 firstPressPos;
    Vector2 secondPressPos;
    Vector2 currentSwipe;

    float rot;

    public GameObject arrow;
    public Transform parent;

    void Awake()
    {
        arrow.transform.rotation = Quaternion.identity;
        rot = 0;
    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 p = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            firstPressPos = Camera.main.ScreenToWorldPoint(p);

            Debug.Log("firstPressPos:" + firstPressPos);
            rot = 0;
            arrow.transform.rotation = Quaternion.identity;
            Debug.Log("first rotation:" + rot);

        }
        if (Input.GetMouseButtonUp(0))
        {
            Vector3 p = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            secondPressPos = Camera.main.ScreenToWorldPoint(p);
            

            Debug.Log("secondPressPos:" + secondPressPos);
            //create vector from the two points
            currentSwipe = new Vector2(secondPressPos.x - firstPressPos.x, secondPressPos.y - firstPressPos.y);

            currentSwipe.Normalize();
            Debug.Log("currentSwipe:" + currentSwipe);
            //normalize the 2d vector

            //swipe upwards
            if (currentSwipe.y > 0 && currentSwipe.x > -0.5f && currentSwipe.x < 0.5f)
            {
                //Debug.Log("up swipe");

                rot = Vector2.Angle(firstPressPos, secondPressPos); //secondPressPos
                float r = Vector2.Angle(Vector2.zero, Vector2.right);
                Debug.Log("sceond rotation:" + r);
                Debug.Log("sceond rotation:"+ rot);

                Debug.Log(currentSwipe);
                arrow.transform.Rotate( 0, 0, rot *-1);

                StartCoroutine(ShowShadowArrowCourtine());
            }
        }
    }

    IEnumerator ShowShadowArrowCourtine()
    {
        GameObject obj = Instantiate(arrow, parent);
        yield return new WaitForSeconds(2f);
        arrow.transform.rotation = Quaternion.identity;
        rot = 0;
        Destroy(obj);
        
    }
}
