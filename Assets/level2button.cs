using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level2button : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    void OnMouseDown() {
        UnityEngine.SceneManagement.SceneManager.LoadScene("level_1");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
