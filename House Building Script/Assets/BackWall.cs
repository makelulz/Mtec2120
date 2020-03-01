using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackWall : MonoBehaviour
{
    public GameObject Brick;
    // Start is called before the first frame update

    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            for (int n = 0; n < 5; n++)
            {
                Instantiate(Brick, new Vector3(i, n, 0), Quaternion.identity);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
