using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    public GameObject cube;
    void Awake()
    {
        for (int c = 0; c < 16; c++)
        {
            for (int j = 0; j < 16; j++)
            {
                Vector3 position = new Vector3(c, 0, j);
                GameObject cubePos = Instantiate(cube, position, Quaternion.identity);
                cubePos.transform.parent = transform;
            }
        }
    }
}
