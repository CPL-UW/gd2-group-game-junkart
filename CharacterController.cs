using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameManager;


namespace CharacterController{
public class CharacterController : MonoBehaviour
{
    public static int speed = 1;
    public static bool moved = false;
    //public bool starter = true;
    // Control the moves
    public void move(){
        
        Vector2 position = transform.position;
        if(Input.GetKeyDown(KeyCode.A)){
            foreach(int[] block in GameManager.GameManager.blocklist){
                if(position.y == block[1] && position.x-speed == block[0]){
                    move();
                }
            }
            foreach(int[] block in GameManager.GameManager.walllist){
                if(position.y == block[1] && position.x-speed == block[0]){
                    move();
                }
            }
            if(position.x-speed < GameManager.GameManager.Xbound[0]){
                move();
            }
            position.x -= speed;
            moved = true;
        }
        if(Input.GetKeyDown(KeyCode.D)){
            foreach(int[] block in GameManager.GameManager.blocklist){
                if(position.y == block[1] && position.x+speed == block[0]){
                    move();
                }
            }
            foreach(int[] block in GameManager.GameManager.walllist){
                if(position.y == block[1] && position.x+speed == block[0]){
                    move();
                }
            }
            if(position.x+speed > GameManager.GameManager.Xbound[1]){
                move();
            }
            position.x += speed;
            moved = true;
        }
        if(Input.GetKeyDown(KeyCode.W)){
            foreach(int[] block in GameManager.GameManager.blocklist){
                if(position.x == block[0] && position.y+speed == block[1]){
                    move();
                }
            }
            foreach(int[] block in GameManager.GameManager.walllist){
                if(position.x == block[0] && position.y+speed == block[1]){
                    move();
                }
            }
            if(position.y+speed > GameManager.GameManager.Ybound[1]){
                move();
            }
            position.y += speed;
            moved = true;
        }
        if(Input.GetKeyDown(KeyCode.S)){
            foreach(int[] block in GameManager.GameManager.blocklist){
                if(position.x == block[0] && position.y-speed == block[1]){
                    move();
                }
            }
            foreach(int[] block in GameManager.GameManager.walllist){
                if(position.x == block[0] && position.y-speed == block[1]){
                    move();
                }
            }
            if(position.y-speed < GameManager.GameManager.Ybound[0]){
                move();
            }            

            position.y -= speed;
            moved = true;
        }
        transform.position = position;
        //Debug.Log(position.x+"\n"+position.y);
        
    }
    // Start is called before the first frame update
    void Start()
    {
        //move();
    }

    // Update is called once per frame
    void Update()
    {
        // if(GameManager.GameManager.checker()){
        //     move();
        // }
        if(!moved){
            move();
            //starter = false;
        }
        //move();
        
    }
}
}