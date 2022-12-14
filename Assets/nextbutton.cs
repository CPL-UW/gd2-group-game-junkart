using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nextbutton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnMouseDown() {
        GameObject.Find("start").GetComponent<Transform>().position = new Vector3(100,0,1);
        GameObject.Find("How to Play button").GetComponent<Transform>().position = new Vector3(100,0,1);
        GameObject.Find("story button").GetComponent<Transform>().position = new Vector3(100,0,1);
        switch(storybutton.story){
            case 1:
                GameObject.Find("Story 1 Page").GetComponent<Transform>().position = new Vector3(100,0,1);
                GameObject.Find("Story 2 Page").GetComponent<Transform>().position = new Vector3(0,0,-2);
                storybutton.story++;
                break;
            case 2:
                GameObject.Find("Story 2 Page").GetComponent<Transform>().position = new Vector3(100,0,1);
                GameObject.Find("Story 3 Page").GetComponent<Transform>().position = new Vector3(0,0,-2);
                storybutton.story++;
                break;
            case 3:
                GameObject.Find("Story 3 Page").GetComponent<Transform>().position = new Vector3(100,0,1);
                GameObject.Find("Story 4 Page").GetComponent<Transform>().position = new Vector3(0,0,-2);
                storybutton.story++;
                break;
            // case 4:
            //     GameObject.Find("Back button").GetComponent<Transform>().position = new Vector3(7.8f,3.59f,1);
            //     break;
        }
        if(storybutton.story == 1){
            Debug.Log("1");
        }
        //GameObject.Find("Story 1 Page").GetComponent<Transform>().position = new Vector3(0,0,-2);
        
        
        
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
