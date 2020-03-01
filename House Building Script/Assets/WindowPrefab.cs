using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowPrefab : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Window;
    void Start()
    {
        for (int i = 1; i < 5; i+=3)
        {
                Instantiate(Window, new Vector3(i, 3, -0.2f), Quaternion.identity);
           
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
