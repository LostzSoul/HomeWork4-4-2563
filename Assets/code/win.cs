using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class win : MonoBehaviour
{
    public GameObject goal;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.Equals(goal))
        {
            Debug.Log("You Win");
        }
    }
}
