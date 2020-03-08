using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUpThenDown : MonoBehaviour
{

    public bool allowControl = true;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > 5)
        {
            allowControl = false;
            
        }

        if (allowControl== false)
        {
            transform.position -= new Vector3(0, 1, 0) * Time.deltaTime;
        }

        if (transform.position.y < -5)
        {
            allowControl = true;
        }

        if(Input.GetKey(KeyCode.W) && allowControl == true)
        {
            transform.position += new Vector3(0, 1, 0) * Time.deltaTime;
        }

        
    }
}
