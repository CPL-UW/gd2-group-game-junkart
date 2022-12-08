using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backbutton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnMouseDown() {
        UnityEngine.SceneManagement.SceneManager.LoadScene("menu");
        // GameObject.Find("How to play scene").GetComponent<Transform>().position = new Vector3(100,0,1);
        // GameObject.Find("start").GetComponent<Transform>().position = new Vector3(100,0,1);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
