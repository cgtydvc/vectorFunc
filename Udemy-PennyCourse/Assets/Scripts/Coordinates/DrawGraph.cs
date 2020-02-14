using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawGraph : MonoBehaviour
{
    public int size = 20;

    [Header("X Coordinate Value")]
    Coordinate xAxisLeftValue = new Coordinate(-100, 0);
    Coordinate xAxisRightValue = new Coordinate(100, 0);

    [Header("Y Coordinate Value")]
    Coordinate yAxisDownValue = new Coordinate(0, -100);
    Coordinate yAxisUpValue = new Coordinate(0, 100);

    private void Start()
    {
        Coordinate.drawXLine(xAxisLeftValue, xAxisRightValue, 1f, Color.red);
        Coordinate.drawXLine(yAxisDownValue, yAxisUpValue, 1f, Color.green);
        int xoffset = (int)(100 / (float)size);
        for (int x = -xoffset * size; x <= xoffset * size; x+=size)
        {
            Coordinate.drawXLine(new Coordinate(x, -100), new Coordinate(x, 100), 0.4f, Color.white);
        }
        int yoffset = (int)(100 / (float)size);
        for (int y = -yoffset * size; y < yoffset * size; y+=size)
        {
            Coordinate.drawXLine(new Coordinate(-100, y), new Coordinate(100, y), 0.4f, Color.white);
        }
    }
}
