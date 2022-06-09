using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class lesScenes : MonoBehaviour
{
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {

       /* Ray ray = Camera.main.ScreenPointToRay(GameObject.Orientation);
        Debug.DrawRay(ray.origin, ray.direction * hit.distance, Color.red);

        if (Physics.Raycast(ray, 100))
        {
            print("hit someting");
        }  
           */
            


        if(Input.GetKeyDown(KeyCode.Space))
        {
           SceneManager.LoadScene("Scene_Man_1");

           // SceneManager.LoadScene("Scene_Man_0");

        }
    }
}
