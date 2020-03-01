using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftWall : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject Brick;
    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            for (int n = 0; n < 5; n++)
            {
                Instantiate(Brick, new Vector3(0, n, i), Quaternion.identity);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
