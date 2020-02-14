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
        diff = fuel.transform.position - this.transform.position;
        Coord coord = PlayerMath.GetNormal(new Coord(diff));
        diff = coord.ToVector();
        float a = PlayerMath.Angle(new Coord(0, 0, 1), new Coord(diff)) * (180.0f / Mathf.PI);
        Debug.Log("angle : " + a);
    }

    void Update()
    {
        if (PlayerMath.Distance(new Coord(this.transform.position),new Coord(fuel.transform.position)) > diffDistance)
        {
            transform.position += diff * speed * Time.deltaTime;
        }
    }
}
