using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigBoi : MonoBehaviour
{
    // Start is called before the first frame update

    public bool allowControl = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (allowControl == true)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                transform.localScale += Vector3.one * Time.deltaTime;
            }
        }

        if (transform.localScale.x > 5)
        {
            allowControl = false;

        }

        if (allowControl == false)
        {
            transform.localScale -= Vector3.one * Time.deltaTime;
        }

        if (transform.localScale.x < 1)
        {
            allowControl = true;
        }
    }
}
