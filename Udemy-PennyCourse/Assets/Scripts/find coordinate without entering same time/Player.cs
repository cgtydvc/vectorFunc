using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject fuel;
    Vector3 diff;
    public float diffDistance = .1f;
    public float speed = 5f;
    void Start()
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        diff = fuel.transform.position - this.transform.position;
        Coord coord = PlayerMath.GetNormal(new Coord(diff));
        diff = coord.ToVector();                                                                                    //// look at method first solutions.
        this.transform.forward = PlayerMath.LookAt3D(new Coord(this.transform.forward),
                                                     new Coord(this.transform.position),
                                                     new Coord(fuel.transform.position)).ToVector();
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /*diff = fuel.transform.position - this.transform.position;
        Coord coord = PlayerMath.GetNormal(new Coord(diff));
        diff = coord.ToVector();
        float a = PlayerMath.Angle(new Coord(this.transform.forward), new Coord(diff));
        bool clockwise = false;
        if (PlayerMath.Cross(new Coord(this.transform.forward),coord).y < 0)                                        ///// look at method second solution.
        {
            clockwise = true;
        }
        Coord coordRot = PlayerMath.Rotate(new Coord(this.transform.forward), a, clockwise);
        this.transform.forward = new Vector3(coordRot.x, coordRot.y, coordRot.z);*/
        //////////////////////////////////////////////////////////////////////////////////////////////////////////
    }

    void Update()
    {
        if (PlayerMath.Distance(new Coord(this.transform.position),new Coord(fuel.transform.position)) > diffDistance)
        {
            transform.position += diff * speed * Time.deltaTime;
        }
    }
}
