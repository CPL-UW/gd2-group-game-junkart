using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace D3{
    public class D3 : MonoBehaviour{
        //public Button but;
        // Start is called before the first frame update
        void Start()
        {
        //Button btn = but.GetComponent<Button>();
        //btn.onClick.AddListener(TaskOnClick);
        }
        void OnMouseDown() {
            Vector3 newRotation = new Vector3(0,0,0);
            GameManager.GameManager.avatar_index = new System.Random().Next(1,4);
            switch(GameManager.GameManager.avatar_index){
                case 1:
                    newRotation = new Vector3(0, 0, 240);
                    //transform.eulerAngles = newRotation;
                    break;
                case 2:
                    newRotation = new Vector3(0, 0, 0);
                    //transform.eulerAngles = newRotation;
                    break;
                case 3:
                    newRotation = new Vector3(0, 0, 120);
                    
                    break;
            }
            transform.eulerAngles = newRotation;
            Debug.Log(GameManager.GameManager.avatar_index);
            //Debug.Log("aaaaaa");
            // return i;
            //return true;
            
        }
        // Update is called once per frame
        void Update()
        {
        
        }
    }
} 
