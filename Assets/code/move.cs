using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    [SerializeField] KeyCode Up;
    [SerializeField] KeyCode Down;
    void Update()
    {
        
        if (Input.GetKey(Up))
        {
            transform.position += new Vector3(0f, 2f, 0f)*Time.deltaTime;
        }
        if (Input.GetKey(Down))
        {
            transform.position -= new Vector3(0f, 2f, 0f)*Time.deltaTime;
        }
       
    }


}
