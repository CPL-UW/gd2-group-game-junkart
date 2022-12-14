using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class storybutton : MonoBehaviour
{
    public static int story = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnMouseDown() {
        GameObject.Find("Story 1 Page").GetComponent<Transform>().position = new Vector3(0,0,-2);
        GameObject.Find("start").GetComponent<Transform>().position = new Vector3(100,0,1);
        GameObject.Find("How to Play button").GetComponent<Transform>().position = new Vector3(100,0,1);
        GameObject.Find("story button").GetComponent<Transform>().position = new Vector3(100,0,1);
        GameObject.Find("Back button").GetComponent<Transform>().position = new Vector3(7.8f,3.59f,1);
        GameObject.Find("Next button").GetComponent<Transform>().position = new Vector3(7.8f,1.59f,1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
