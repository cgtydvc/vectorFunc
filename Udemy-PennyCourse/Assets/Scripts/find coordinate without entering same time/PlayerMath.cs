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
    static public Coord LookAt3D(Coord forwardVector, Coord position, Coord directiontoTarget)
    {
        Coord direction = new Coord(position.x - directiontoTarget.x, position.y - directiontoTarget.y, position.z);
        float angle = PlayerMath.Angle(forwardVector, direction);
        bool clockwise = false;
        if (PlayerMath.Cross(forwardVector,direction).z < 0)
        {
            clockwise = true;
        }
        Coord rotate = PlayerMath.Rotate(forwardVector, angle, clockwise);
        return rotate;
    }
    static public float Angle(Coord vector1, Coord vector2)
    {
        float dotPoint = Dot(vector1, vector2) / (Distance(new Coord(0, 0, 0), vector1) * Distance(new Coord(0, 0, 0), vector2));
        return Mathf.Acos(dotPoint);
    }
    static public Coord Rotate(Coord vector, float angle, bool clockwise)
    {
        if (clockwise)
        {
            angle = 2 * Mathf.PI - angle;
        }
        float xVal = vector.x * Mathf.Cos(angle) - vector.y * Mathf.Sin(angle);
        float yVal = vector.x * Mathf.Sin(angle) + vector.y * Mathf.Cos(angle);
        return new Coord(xVal, yVal, 0);
    }
    static public Coord Cross(Coord vec1,Coord vec2)
    {
        return new Coord(vec1.y * vec2.z - vec1.z * vec2.y, vec1.z * vec2.x - vec1.x * vec2.z, vec1.x * vec2.y - vec1.y * vec2.x);
    }
}
