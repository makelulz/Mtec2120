using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ceiling : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Brick;
    void Start()
    {
        for (int i = 0; i < 6; i++)
        {
            for (int n = 0; n < 6; n++)
            {
                Instantiate(Brick, new Vector3(i, 5, n), Quaternion.identity);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
