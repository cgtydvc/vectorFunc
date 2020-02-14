using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMath : MonoBehaviour
{
    static public Coord GetNormal(Coord vector)
    {
        float length = Distance(new Coord(0, 0, 0), vector);
        vector.x /= length;
        vector.y /= length;
        vector.z /= length;
        return vector;
    }
    static public float Distance(Coord point1, Coord point2)
    {
        float diffSquare = Square(point1.x - point2.x) + Square(point1.y - point2.y) + Square(point1.z - point2.z);
        float squareRoot = Mathf.Sqrt(diffSquare);
        return squareRoot;
    }
    static public float Square(float value)
    {
        return value * value;
    }
    static public float Dot(Coord point1, Coord point2)
    {
        return (point1.x * point2.x + point1.y * point2.y + point1.z * point2.z);
    }
    static public float Angle(Coord vector1, Coord vector2)
    {
        float dotPoint = Dot(vector1, vector2) / (Distance(new Coord(0, 0, 0), vector1) * Distance(new Coord(0, 0, 0), vector2));
        return Mathf.Acos(dotPoint);
    }

}
