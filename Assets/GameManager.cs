using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CharacterController;
namespace GameManager{
    public class GameManager : MonoBehaviour
{   
    public static int[] Xbound = new int[]{-7,7};
    public static int[] Ybound = new int[]{-7,7};
    public static int[][] blocklist = {new int[]{1,-1}};
    /* wall: int[]{Xpos, Ypos, Color} */
    public static int[][] walllist = {new int[]{-3,-6, 0}, new int[]{-2,-6, 0}, new int[]{-1,-6, 0}, new int[]{0,-6, 0}, new int[]{1,-6, 0}, new int[]{2,-6, 0}, new int[]{3,-6, 0},
                                    new int[]{-4,-6, 0}, new int[]{-4,-5, 0}, new int[]{-4,-5, 0}, new int[]{-4,-4, 0}, new int[]{-4,-3, 0}, new int[]{-4,-2, 0}, new int[]{-5,-2, 0}, new int[]{-5,-1, 0}, new int[]{-5, 0, 0}, new int[]{-5,1, 0}, new int[]{-5,2, 0}, new int[]{-5,3, 0}, new int[]{-5,4, 0}, new int[]{-5,5, 0}, 
                                    new int[]{4,-6, 0}, new int[]{4,-5, 0}, new int[]{4,-5, 0}, new int[]{4,-4, 0}, new int[]{4,-3, 0}, new int[]{4,-2, 0}, new int[]{5,-2, 0}, new int[]{5,-1, 0}, new int[]{5, 0, 0}, new int[]{5,1, 0}, new int[]{5,2, 0}, new int[]{5,3, 0}, new int[]{5,4, 0}, new int[]{5,5, 0}, 
                                    new int[]{-4,5, 0}, new int[]{-3,5, 0}, new int[]{-2,5, 0}, new int[]{-1,5, 0}, new int[]{0,5, 0}, new int[]{1,5, 0}, new int[]{2,5, 0}, new int[]{3,5, 0}, new int[]{4,5, 0}};
    public static int round;
    public static int step = 1000;
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
                //moved = false;
                step = 3;                
                Debug.Log(round++);
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
        //Debug.Log(CharacterController.CharacterController.step);
        //CharacterController.CharacterController.move();
        //Debug.Log(checker());
        //checker();

    }
}
}
