using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coordinate : MonoBehaviour
{

    float x;
    float y;
    float z;

    public Coordinate(float _x, float _y)
    {
        x = _x;
        y = _y;
        z = -1;
    }
    public override string ToString()
    {
        return "(" + x + "," + y + "," + z + "" + ")";
    }
    static public void drawPoints(Coordinate position, float width, Color colour)
    {
        GameObject line = new GameObject("Point" + position.ToString()); //yeni bir gameobje oluşturdum.
        LineRenderer lineRenderer = line.AddComponent<LineRenderer>(); //line render ekledim.
        lineRenderer.material.color = colour; //material ekleyip buna rengini verdim.
        lineRenderer.positionCount = 2; //pozisyonunu döndürdüm
        lineRenderer.SetPosition(0, new Vector3((position.x - width / 3.0f), position.y - width / 3.0f, position.z)); //set ettim 
        lineRenderer.SetPosition(1, new Vector3((position.x + width / 3.0f), position.y + width / 3.0f, position.z));
        lineRenderer.startWidth = width;
        lineRenderer.endWidth = width;
    }
    static public void drawLine(Coordinate starPos, Coordinate endPos, float width, Color colour)
    {
        GameObject line = new GameObject("starPos" + starPos.ToString() + "endPos" + endPos.ToString()); //yeni bir gameobje oluşturdum.
        LineRenderer lineRenderer = line.AddComponent<LineRenderer>(); //line render ekledim.
        lineRenderer.material.color = colour; //material ekleyip buna rengini verdim.
        lineRenderer.positionCount = 2; //pozisyonunu döndürdüm
        lineRenderer.SetPosition(0, new Vector3(starPos.x, starPos.y, starPos.z)); //set ettim 
        lineRenderer.SetPosition(1, new Vector3(starPos.x, endPos.y, starPos.z));
        lineRenderer.startWidth = width;
        lineRenderer.endWidth = width;
    }
    static public void drawXLine(Coordinate leftPos, Coordinate rightPos,float width, Color colour)
    {
        GameObject line = new GameObject("leftpos" + leftPos.ToString() + "rightpos" + rightPos.ToString());
        LineRenderer lineRenderer = line.AddComponent<LineRenderer>();
        lineRenderer.material.color = colour;
        lineRenderer.positionCount = 2;
        lineRenderer.SetPosition(0, new Vector3(leftPos.x, leftPos.y,leftPos.z));
        lineRenderer.SetPosition(1, new Vector3(rightPos.x, rightPos.y, rightPos.z));
        lineRenderer.startWidth = width;
        lineRenderer.endWidth = width;
    }


}

