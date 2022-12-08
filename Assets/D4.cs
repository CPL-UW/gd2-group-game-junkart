using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using GameManager;
public class D4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnMouseDown() {
        //Debug.Log("aaaaaaa");

            //Debug.Log("aaaaaa");
            // return i;
            //return true;
        
        }
    // Update is called once per frame
    void Update()
    {
     if(Input.GetKeyDown(KeyCode.Keypad0)){
                 if(GameManager.GameManager.cursed == 0){
            Vector3 newRotation = new Vector3(0,0,0);
            GameManager.GameManager.color = new System.Random().Next(0,4);
            switch(GameManager.GameManager.color){
                case 1:
                    newRotation = new Vector3(0, 0, 120);
                    break;
                case 2:
                    newRotation = new Vector3(0, 0, 60);
                    break;
                case 3:
                    newRotation = new Vector3(0, 0, 320);
                    break;
                case 0:
                    newRotation = new Vector3(0, 0, 210);
                    break;
            }
            transform.eulerAngles = newRotation;
            Debug.Log(GameManager.GameManager.color);
            GameManager.GameManager.cursed = 1;
                 }
    }
    }
}
