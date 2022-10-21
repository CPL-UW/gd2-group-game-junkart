using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameManager;


namespace CharacterController{
public class CharacterController : MonoBehaviour
{
    public static int speed = 1;
    //public static int moved = 3;
    public bool starter = true;
    // Control the moves
    public void move(){
        
            //Debug.Log("Charactor 1");
            Vector2 position = transform.position;
            int done = 1;
            if(Input.GetKeyDown(KeyCode.A)){
                done = 2;
            foreach(int[] block in GameManager.GameManager.blocklist){
                if(position.y == block[1] && position.x-speed == block[0]){
                    done = 0;
                }
            }
            foreach(int[] block in GameManager.GameManager.walllist){
                if(position.y == block[1] && position.x-speed == block[0]){
                    done = 0;
                }
            }
            if(position.x-speed < GameManager.GameManager.Xbound[0]){
                done = 0;
            }

            position.x -= speed;

        }
        if(Input.GetKeyDown(KeyCode.D)){
            done = 2;
            foreach(int[] block in GameManager.GameManager.blocklist){
                if(position.y == block[1] && position.x+speed == block[0]){
                    done = 0;
                }
            }
            foreach(int[] block in GameManager.GameManager.walllist){
                if(position.y == block[1] && position.x+speed == block[0]){
                    done = 0;
                }
            }
            if(position.x+speed > GameManager.GameManager.Xbound[1]){
                done = 0;
            }
            position.x += speed;
        }
        if(Input.GetKeyDown(KeyCode.W)){
            done = 2;
            foreach(int[] block in GameManager.GameManager.blocklist){
                if(position.x == block[0] && position.y+speed == block[1]){
                    done = 0;
                }
            }
            foreach(int[] block in GameManager.GameManager.walllist){
                if(position.x == block[0] && position.y+speed == block[1]){
                    done = 0;
                }
            }
            if(position.y+speed > GameManager.GameManager.Ybound[1]){
                done = 0;
            }
            position.y += speed;
            
        }
        if(Input.GetKeyDown(KeyCode.S)){
            done = 2;
            foreach(int[] block in GameManager.GameManager.blocklist){
                if(position.x == block[0] && position.y-speed == block[1]){
                    done = 0;
                }
            }
            foreach(int[] block in GameManager.GameManager.walllist){
                if(position.x == block[0] && position.y-speed == block[1]){
                    done = 0;
                }
            }
            if(position.y-speed < GameManager.GameManager.Ybound[0]){
                done = 0;
            }            
            position.y -= speed;           
        }
        
        if(done == 2){
            GameManager.GameManager.step--;
            transform.position = position;
            //Debug.Log(GameManager.GameManager.step);
        }
        else if(done==0){
            move();
        }
        
        
        
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        if(starter){
            Debug.Log("start");
            move();
            starter = false;
        }
        if(GameManager.GameManager.step == 0 || Input.GetKeyDown(KeyCode.Space)){
            GameManager.GameManager.step = 0;
            GameManager.GameManager.checker();    
        }else{
            move();
        }
        
    }
}
}