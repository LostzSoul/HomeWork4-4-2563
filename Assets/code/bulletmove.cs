using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletmove : MonoBehaviour
{
    [SerializeField] float speed;
     void Update()
    {
        transform.Translate(0f, -speed * Time.deltaTime, 0f);
        if(transform.position.x >= 20)
        {
            Destroy(gameObject);
        }
    }
    
    
    
    
    /*private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }*/
}
