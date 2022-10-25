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
    /* block: int[]{Xpos, Ypos, Color} */
    public static int[][] blocklist = {new int[]{1,1,0}, new int[]{-1,1,1}, new int[]{-3,1,2}, new int[]{3,1,3}, new int[]{-1,-2,2}, new int[]{1,-2,0}, new int[]{-1,-4,1}, new int[]{1,-4,3}};
    
    public static int[][] walllist = {new int[]{-3,-6}, new int[]{-2,-6}, new int[]{-1,-6}, new int[]{0,-6}, new int[]{1,-6}, new int[]{2,-6}, new int[]{3,-6},
                                    new int[]{-4,-6}, new int[]{-4,-5}, new int[]{-4,-5}, new int[]{-4,-4}, new int[]{-4,-3}, new int[]{-4,-2}, new int[]{-5,-2}, new int[]{-5,-1}, new int[]{-5, 0}, new int[]{-5,1}, new int[]{-5,2}, new int[]{-5,3}, new int[]{-5,4}, new int[]{-5,5}, 
                                    new int[]{4,-6}, new int[]{4,-5}, new int[]{4,-5}, new int[]{4,-4}, new int[]{4,-3}, new int[]{4,-2}, new int[]{5,-2}, new int[]{5,-1}, new int[]{5, 0}, new int[]{5,1}, new int[]{5,2}, new int[]{5,3}, new int[]{5,4}, new int[]{5,5}, 
                                    new int[]{-4,5}, new int[]{-3,5}, new int[]{-2,5}, new int[]{-1,5}, new int[]{0,5}, new int[]{1,5}, new int[]{2,5}, new int[]{3,5}, new int[]{4,5}};
    public static int round;
    public static int step = 3;
    public static int avatar_index;
    public static int color = -1;
    public static ArrayList tmpblock;
    public bool starter = true;
    // Start is called before the first frame update
    void Start()
    {
        round = 1;

    }
    public static bool checker(){
        
        if(step == 0){


            int counter = 0;
            /**
            *
            *   Trigger for random generating colored dice, goto line 36
            *                           ||
            *                         \ || /
            *                           \/
            **/
            //color = new System.Random().Next(0,4);
            color = 2;
            if(color != -1){
                //Debug.Log(color);
                tmpblock = new ArrayList();
                foreach(int[] block in blocklist){
                    if(block[2] == color){
                        tmpblock.Add(block);
                    }
                }

                /**
                *   need a wait until lock here below
                */
                //if(Input.GetKeyDown(KeyCode.RightArrow)){
                    Vector2 position = GameObject.Find("BlockPointer").GetComponent<Transform>().position;
                    position.x = ((int[]) tmpblock[counter])[0]+0.75f;
                    position.y = ((int[]) tmpblock[counter])[1]-0.25f;
                    //Debug.Log(((int[]) tmpblock[0])[0]);
                    GameObject.Find("BlockPointer").GetComponent<Transform>().position = position;
                    //counter++;
                //}
            }

            if(move(0)){
                Debug.Log(blocklist[0][0]/2f+"  "+blocklist[0][1]/2f);
                step = 3;
            /**
            *
            *   Trigger for random generating colored dice, roll a dice to pick up an avatar
            *                           ||
            *                         \ || /
            *                           \/
            **/                
                avatar_index = new System.Random().Next(1,4);
                color = -1;
                tmpblock = null;
                return true;
            }
            
        }
        return false;
    }

    public static bool move(int index){
        if(Input.GetKeyDown(KeyCode.LeftArrow)){
            blocklist[index][0]--;
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
    }
}
}
