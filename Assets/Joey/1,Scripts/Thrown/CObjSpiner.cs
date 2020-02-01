using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CObjSpiner : MonoBehaviour
{
    public GameObject SpinObj;
    [Range(-1200,1200.0f)]
    public float _spinPower = 600.0f;
    // Update is called once per frame
    void Update()
    {
        SpinObj.transform.Rotate(0,0, _spinPower * Time.deltaTime);
    }
}
