using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Range(0.00001f, 1f)]
    public float speed;
    
    
    public void Move(Vector3 direction)
    {
        transform.Translate(direction * speed);
    }
}
