using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript : MonoBehaviour
{
    public GameObject sphere;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("Object is activated");
            sphere.SetActive(true);
        }
        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("Object is deactivated");
            sphere.SetActive(false);
        }

    }
}
