using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAction : MonoBehaviour
{
    public PlayerMovement movement;
    public KeyCode haut, bas, gauche, droite;




    void Update()
    {
        if (Input.GetKey(haut))
        {
            movement.Move(Vector3.forward);
        }
        if (Input.GetKey(bas))
        {
            movement.Move(Vector3.back);
        }
        if (Input.GetKey(gauche))
        {
            movement.Move(Vector3.left);
        }
        if (Input.GetKey(droite))
        {
            movement.Move(Vector3.right);
        }
    }
}
