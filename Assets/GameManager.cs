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
    /* 0: red, 1: blue, 2: green, 3: yellow */
    /* block: int[]{Xpos, Ypos, Color} */
    public static int[][] blocklist = {new int[]{1,1,2}, new int[]{-1,1,1}, new int[]{-3,1,0}, new int[]{3,1,3}, new int[]{-1,-2,2}, new int[]{1,-2,0}, new int[]{-1,-4,1}, new int[]{1,-4,3}};
    
    public static int[][] walllist = {new int[]{-3,-6}, new int[]{-2,-6}, new int[]{-1,-6}, new int[]{0,-6}, new int[]{1,-6}, new int[]{2,-6}, new int[]{3,-6},
                                    new int[]{-4,-6}, new int[]{-4,-5}, new int[]{-4,-5}, new int[]{-4,-4}, new int[]{-4,-3}, new int[]{-4,-2}, new int[]{-5,-2}, new int[]{-5,-1}, new int[]{-5, 0}, new int[]{-5,1}, new int[]{-5,2}, new int[]{-5,3}, new int[]{-5,4}, new int[]{-5,5}, 
                                    new int[]{4,-6}, new int[]{4,-5}, new int[]{4,-5}, new int[]{4,-4}, new int[]{4,-3}, new int[]{4,-2}, new int[]{5,-2}, new int[]{5,-1}, new int[]{5, 0}, new int[]{5,1}, new int[]{5,2}, new int[]{5,3}, new int[]{5,4}, new int[]{5,5}, 
                                    new int[]{-4,5}, new int[]{-3,5}, new int[]{-2,5}, new int[]{-1,5}, new int[]{0,5}, new int[]{1,5}, new int[]{2,5}, new int[]{3,5}, new int[]{4,5}, new int[]{1,1,2}, new int[]{-1,1,1}, new int[]{-3,1,0}, new int[]{3,1,3}, new int[]{-1,-2,2}, new int[]{1,-2,0}, new int[]{-1,-4,1}, new int[]{1,-4,3}};
    public static int round;
    public static int step = 3;
    public static int avatar_index;
    public static int color = -1;
    public static ArrayList tmpblock;
    public bool starter = true;
    public static int counter = 0;
    public static bool cursored = false;
    public static int index = 0;
    public static int[][] originBlock;
    public static float[] red_panda = new float[]{0,-1.5f};
    // Start is called before the first frame update
    void Start()
    {
        round = 1;
        originBlock = new int[blocklist.Length][];
        int ct = 0;
        foreach(int[] block in blocklist){
            originBlock[ct] = new int[]{block[0], block[1], block[2]};
            // originBlock[ct][1] = block[1];
            // originBlock[ct][2] = block[2];
            ct++;
        }

    }
    public static bool checker(){
        
        if(step == 0){


            
            /**
            *
            *   Trigger for random generating colored dice, goto line 36
            *                           ||
            *                         \ || /
            *                           \/
            **/
            //color = new System.Random().Next(0,4);
            //color = 0;
            if(color != -1){
                //Debug.Log(color);
                tmpblock = new ArrayList();
                foreach(int[] block in blocklist){
                    if(block[2] == color){
                        tmpblock.Add(block);
                    }
                }
            cursor(tmpblock, counter);
                /**
                *   need a wait until lock here below
                */
                //if(Input.GetKeyDown(KeyCode.RightArrow)){
                    // Vector2 position = GameObject.Find("BlockPointer").GetComponent<Transform>().position;
                    // position.x = ((int[]) tmpblock[counter])[0]/2f;
                    // position.y = ((int[]) tmpblock[counter])[1]/2f;
                    // //Debug.Log(((int[]) tmpblock[0])[0]);
                    // GameObject.Find("BlockPointer").GetComponent<Transform>().position = position;
                    //cursor(tmpblock, counter);
                //}
            }else{
                //checker();
                return false;
            }
            
            if(Input.GetKeyDown(KeyCode.Return)){
                cursored = true;
                Vector2 position = GameObject.Find("BlockPointer").GetComponent<Transform>().position;
                for(int i = 0; i< blocklist.Length; i++){
                    if(blocklist[i][0]/2f == position.x && blocklist[i][1]/2f == position.y){
                        index = i;
                    }
                }
            }
            if(!cursored){
                if(Input.GetKeyDown(KeyCode.RightArrow)){
                    if(counter == tmpblock.Count-1){
                        counter = 0;
                    }else{
                        counter++;
                    }   
                }
                if(Input.GetKeyDown(KeyCode.LeftArrow)){
                    if(counter == 0){
                        counter = tmpblock.Count-1;
                    }else{
                        counter--;
                    }   
                }
            }else{
                //Debug.Log(index);
                if( cursor(tmpblock, counter) && move(index) &&  cursor(tmpblock, counter)){
                //Debug.Log(blocklist[0][0]/2f+"  "+blocklist[0][1]/2f);
                step = 3;
            /**
            *
            *   Trigger for random generating colored dice, roll a dice to pick up an avatar
            *                           ||
            *                         \ || /
            *                           \/
            **/                
                //avatar_index = new System.Random().Next(1,4);
                color = -1;
                tmpblock = null;
                //counter++;
                round++;
                cursored=false;
                index = 0;
                avatar_index=0;
                color = -1;
                if(round > 10){
                    Debug.Log("p2 win!");
                    GameObject.Find("p2wins").GetComponent<Transform>().position = new Vector3(0,0,1);
                }
                return true;
            }
            }

           
            
        }
        return false;
    }
    public static bool cursor(ArrayList tmpblock, int counter){
        Vector2 position = GameObject.Find("BlockPointer").GetComponent<Transform>().position;
        position.x = ((int[]) tmpblock[counter])[0]/2f;
        position.y = ((int[]) tmpblock[counter])[1]/2f;
        //Debug.Log(((int[]) tmpblock[0])[0]);
        GameObject.Find("BlockPointer").GetComponent<Transform>().position = position;
        return true;
    }

    public static bool move(int index){
        if(blocklist[index][0]-1 >= originBlock[index][0]-1 && Input.GetKeyDown(KeyCode.LeftArrow)){
            blocklist[index][0]--;
            return true;
        }
        if(blocklist[index][0]+1 <= originBlock[index][0]+1 && Input.GetKeyDown(KeyCode.RightArrow)){
            blocklist[index][0]++;
            return true;
        }
        if(blocklist[index][1]-1 >= originBlock[index][1]-1 && Input.GetKeyDown(KeyCode.DownArrow)){
            blocklist[index][1]--;
            return true;
        }
        if(blocklist[index][1]+1 <= originBlock[index][1]+1 && Input.GetKeyDown(KeyCode.UpArrow)){
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
            //avatar_index = D3.D3.OnMouseDown();
            //avatar_index = new System.Random().Next(1,4);
            //Debug.Log(avatar_index);
            switch(avatar_index){
                case 2:
                    GameObject.Find("Avatar_1").GetComponent<CharacterController.CharacterController>().move();
                    break;
                case 1:
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
                case 2:
                    GameObject.Find("Avatar_1").GetComponent<CharacterController.CharacterController>().move();
                    break;
                case 1:
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
