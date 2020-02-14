using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BoardManager : MonoBehaviour
{
    public GameObject[] collects;
    public GameObject item;
    public Text text;
    void Start()
    {
        for (int r = 0; r <= 8; r++)
        {
            for (int c = 0; c <= 8; c++)
            {
                int tileMap = UnityEngine.Random.Range(0, collects.Length);
                Vector3 newVector = new Vector3(c, 0, r);
                GameObject tile = Instantiate(collects[tileMap],newVector,Quaternion.identity);
                tile.transform.parent = transform;
            }
        }
        
    }

    void Update()
    {
        
    }
}
