using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CharacterController;
namespace GameManager{
    public class GameManager : MonoBehaviour
{   
    public static int[] Xbound = new int[]{-8,7};
    public static int[] Ybound = new int[]{-5,4};
    public static int[][] blocklist = {new int[]{1,-1}};
    public static int[][] walllist = {new int[]{2,-1}};
    public static int round;
    public static bool moved = false;
    // Start is called before the first frame update
    void Start()
    {
        round = 1;
        //CharacterController.CharacterController.move();
    }
    public static bool checker(){
        
        if(CharacterController.CharacterController.moved){
            //Debug.Log("aa");
            //if()
            //move(0);
            if(move(0)){
                //moved = false;
                CharacterController.CharacterController.moved = false;                
                //Debug.Log(round++);
                return true;
            }
            
        }
        return false;
    }

    public static bool move(int index){
        if(Input.GetKeyDown(KeyCode.LeftArrow)){
            blocklist[index][0]--;
            Debug.Log("did");
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
        checker();

    }
}
}
