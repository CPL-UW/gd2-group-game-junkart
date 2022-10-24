using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CharacterController;
using System;
namespace GameManager{
    public class GameManager : MonoBehaviour
{   
    public static int[] Xbound = new int[]{-7,7};
    public static int[] Ybound = new int[]{-7,7};
    /* 0: red, 1: pink, 2: green, 3: yellow */
    public static int[][] blocklist = {new int[]{1,1,0}, new int[]{-1,1,1}, new int[]{-3,1,2}, new int[]{3,1,3}, new int[]{-1,-2,2}, new int[]{1,-2,0}, new int[]{-1,-4,1}, new int[]{1,-4,3}};
    /* wall: int[]{Xpos, Ypos, Color} */
    public static int[][] walllist = {new int[]{-3,-6}, new int[]{-2,-6}, new int[]{-1,-6}, new int[]{0,-6}, new int[]{1,-6}, new int[]{2,-6}, new int[]{3,-6},
                                    new int[]{-4,-6}, new int[]{-4,-5}, new int[]{-4,-5}, new int[]{-4,-4}, new int[]{-4,-3}, new int[]{-4,-2}, new int[]{-5,-2}, new int[]{-5,-1}, new int[]{-5, 0}, new int[]{-5,1}, new int[]{-5,2}, new int[]{-5,3}, new int[]{-5,4}, new int[]{-5,5}, 
                                    new int[]{4,-6}, new int[]{4,-5}, new int[]{4,-5}, new int[]{4,-4}, new int[]{4,-3}, new int[]{4,-2}, new int[]{5,-2}, new int[]{5,-1}, new int[]{5, 0}, new int[]{5,1}, new int[]{5,2}, new int[]{5,3}, new int[]{5,4}, new int[]{5,5}, 
                                    new int[]{-4,5}, new int[]{-3,5}, new int[]{-2,5}, new int[]{-1,5}, new int[]{0,5}, new int[]{1,5}, new int[]{2,5}, new int[]{3,5}, new int[]{4,5}};
    public static int round;
    public static int step = 3;
    public static int avatar_index;
    public bool starter = true;
    // Start is called before the first frame update
    void Start()
    {
        round = 1;
        //CharacterController.CharacterController.move();
    }
    public static bool checker(){
        
        if(step == 0){
            //Debug.Log("aa");
            //if()
            //move(0);
            if(move(0)){
                Debug.Log(blocklist[0][0]/2f+"  "+blocklist[0][1]/2f);
                //moved = false;
                step = 3;                
                //Debug.Log(round++);
                avatar_index = new System.Random().Next(1,4);
                //Debug.Log(avatar_index);
                return true;
            }
            
        }
        return false;
    }

    public static bool move(int index){
        if(Input.GetKeyDown(KeyCode.LeftArrow)){
            blocklist[index][0]--;
            //Debug.Log("did");
            return true;
        }
        if(Input.GetKeyDown(KeyCode.RightArrow)){
            blocklist[index][0]++;
            return true;
        }
        if(Input.GetKeyDown(KeyCode.DownArrow)){
            blocklist[index][1]--;
            return true;
        }
        if(Input.GetKeyDown(KeyCode.UpArrow)){
            blocklist[index][1]++;
            return true;
        }
        return false;               
    }
    // Update is called once per frame
    void Update()
    {   
        if(starter){
            Debug.Log("start");
            avatar_index = new System.Random().Next(1,4);
            //switch 
                    //GameObject.Find("Avatar_1").GetComponent<CharacterController.CharacterController>().move();

            switch(avatar_index){
                case 1:
                    GameObject.Find("Avatar_1").GetComponent<CharacterController.CharacterController>().move();
                    break;
                case 2:
                    GameObject.Find("Avatar_2").GetComponent<CharacterController.CharacterController>().move();
                    break;
                case 3:
                    GameObject.Find("Avatar_3").GetComponent<CharacterController.CharacterController>().move();
                    break;
            }
            
            starter = false;
        }
        if(step == 0 || Input.GetKeyDown(KeyCode.Space)){
            step = 0;
            checker();    
        }else{
                                //GameObject.Find("Avatar_1").GetComponent<CharacterController.CharacterController>().move();

            switch(avatar_index){
                case 1:
                    GameObject.Find("Avatar_1").GetComponent<CharacterController.CharacterController>().move();
                    break;
                case 2:
                    GameObject.Find("Avatar_2").GetComponent<CharacterController.CharacterController>().move();
                    break;
                case 3:
                    GameObject.Find("Avatar_3").GetComponent<CharacterController.CharacterController>().move();
                    break;
            }
        }
        //Debug.Log(CharacterController.CharacterController.step);
        //CharacterController.CharacterController.move();
        //Debug.Log(checker());
        //checker();

    }
}
}
