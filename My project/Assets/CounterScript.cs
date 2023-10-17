using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CounterScript : MonoBehaviour
{

    public Text CounterText;
    public CollisionScript CubeScript;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        CounterText.text = "Score: " + CubeScript.score;
    }
}
