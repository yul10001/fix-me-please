using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GazeBar : MonoBehaviour
{

    public Image rightGazeBar;
    public Image leftGazeBar;

    public GameObject logo;

    public float velocityValue;

    int speed = 60;

    bool leftCheck=false;
    bool rightCheck = false;

    void Awake()
    {
        rightGazeBar.fillAmount = 0;
        leftGazeBar.fillAmount = 0;
    }

    void Update()
    {
        ProgressBar();
    }

    void ProgressBar()
    {
        leftCheck = Input.GetKey(KeyCode.A) ? true : false;
        rightCheck = Input.GetKey(KeyCode.D) ? true : false;

        if (leftCheck)
        {
            logo.transform.Rotate(Vector3.forward * Time.deltaTime * speed);
            if (velocityValue < 100 && velocityValue > -100)
            {
                velocityValue += 1;
                leftGazeBar.fillAmount = velocityValue * 0.01f;
            }
        }else
        {
            if (velocityValue <= 100 && velocityValue > 0)
            {
                velocityValue -= 1;
                leftGazeBar.fillAmount = velocityValue * 0.01f;
            }
        }

        if (rightCheck)
        {
            logo.transform.Rotate(Vector3.back * Time.deltaTime * speed);

            if (velocityValue > -100 && velocityValue < 100)
            {
                velocityValue -= 1;
                rightGazeBar.fillAmount = velocityValue * -0.01f;
            }
        }else
        {
            if (velocityValue >= -100 && velocityValue < 0)
            {
                velocityValue += 1;
                rightGazeBar.fillAmount = velocityValue * -0.01f;
            }
        }

    }
}
