using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLines : MonoBehaviour
{
    Coordinate coordinate = new Coordinate(10, 20);
    Coordinate startPoint = new Coordinate(0, 100);
    Coordinate endPoint   = new Coordinate(0, -100);
    Coordinate leftXPos   = new Coordinate(100, 0);
    Coordinate rightXPos  = new Coordinate(-100, 0);
    Coordinate[] starPoints ={
                            new Coordinate(10,10),
                            new Coordinate(15,10),
                            new Coordinate(15,15),
                            new Coordinate(20,22),
                            new Coordinate(30,27),
                            new Coordinate(32,18),
                              };

    private void Start()
    {
        //Debug.Log(coordinate.ToString());
        //Coordinate.drawPoints(coordinate, 2, Color.white);
        //Coordinate.drawPoints(new Coordinate(0, 0), 2, Color.blue);
        //Coordinate.drawLine(startPoint, endPoint, 1f, Color.green);
        //Coordinate.drawXLine(leftXPos, rightXPos, 1f, Color.white);

        foreach (Coordinate coord in starPoints) // find point on x and y axis.
        {
            Coordinate.drawPoints(coord, .8f, Color.red);
        }
        Coordinate.drawXLine(starPoints[0], starPoints[2], .3f, Color.blue );
        Coordinate.drawXLine(starPoints[1], starPoints[2], .3f, Color.blue );
        Coordinate.drawXLine(starPoints[2], starPoints[3], .3f, Color.blue );
        Coordinate.drawXLine(starPoints[3], starPoints[4], .3f, Color.blue );
        Coordinate.drawXLine(starPoints[4], starPoints[5], .3f, Color.blue );
        Coordinate.drawXLine(starPoints[5], starPoints[1], .3f, Color.blue );
    }


}
