using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CZoomer : MonoBehaviour
{
    public GameObject   ZoomObj;
    public Transform    TargetObj;
    public CObjMover    MovObj;

    public float        _defaultYPosition;
    public float        _ZoomSizePerDist;
    public bool         _isDefaultSeted = false;

    
    private void Update()
    {
        if (MovObj._isMove)
        {
            _isDefaultSeted = false;
            float currentY = ZoomObj.transform.position.y - _defaultYPosition;
            ZoomObj.transform.localScale = new Vector3(1 - currentY * _ZoomSizePerDist, 1 - currentY * _ZoomSizePerDist, 1);
        }else
        {
            if(!_isDefaultSeted)
            {
                SetDefault();
            }
        }
    }

    void SetDefault()
    {
        ZoomObj.transform.localScale    = new Vector3(1,1,1);
        _defaultYPosition               = ZoomObj.transform.position.y;
        _ZoomSizePerDist                = 0.7f/CalDisOfY();
        _isDefaultSeted                 = true;
    }

    float CalDisOfY()
    {
        return TargetObj.position.y - ZoomObj.transform.position.y;
    }
}
