using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowAni : MonoBehaviour
{

    public Animator ani;

    void Start()
    {
        ani.SetBool("Bool",true);
    }

    public void End()
    {
        ani.SetBool("Bool", false);
    }

}
