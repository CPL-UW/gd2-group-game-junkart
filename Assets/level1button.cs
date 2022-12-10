using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameManager;
public class level1button : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnMouseDown() {
        Debug.Log("1");
        GameManager.GameManager.level = 1;
        UnityEngine.SceneManagement.SceneManager.LoadScene("level_1");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
