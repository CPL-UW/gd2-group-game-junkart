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
        Debug.Log("2");
        GameManager.GameManager.level = 2;
        UnityEngine.SceneManagement.SceneManager.LoadScene("level_2");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
