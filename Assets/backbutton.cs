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
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
