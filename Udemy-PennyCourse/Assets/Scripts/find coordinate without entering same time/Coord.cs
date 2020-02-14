using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coord : MonoBehaviour
{
    public float x;
    public float y;
    public float z;

    public Coord(float _x, float _y, float _z)
    {
        x = _x;
        y = _y;
        z = _z;
    }
    public Coord(Vector3 vec)
    {
        x = vec.x;
        y = vec.y;
        z = vec.z;
    }
    public Vector3 ToVector()
    {
        return new Vector3(x,y,z);
    }
}
