using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CCollSizeController : MonoBehaviour
{
    //Reference Parameter
    public BoxCollider2D coll2D;

    //Inner Parameter
    public string   _ObjName;
    [Range(0,10.0f)]
    public float    _power;
    [Range(0,5f)]
    public float    _xSpeed;
    public bool     _isFlip = true;

    //public float _height;
    //public float _wide;
    //private float collSizeX;
    //public  float CollSizeX
    //{
    //    get { return collSizeX; }
    //    set { if (collSizeX != value)
    //            {
    //            collSizeX = value;
    //            TransformcollSizeX(collSizeX);
    //            }
    //        }
    //}

    //private void TransformcollSizeX(float value)
    //{
    //    coll2D.size = new Vector2( value , 0);
    //    coll2D.offset = new Vector2(value * 0.5f, 0);
    //}

    private void Start()
    {
        _isFlip = coll2D.gameObject.transform.localScale.x > 0;
    }

    public float GetPower()
    {
        return _xSpeed *(_isFlip ? _power : -_power);
    }

}
