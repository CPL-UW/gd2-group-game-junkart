using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameManager;


namespace CharacterController{
public class CharacterController : MonoBehaviour
{
    public float speed = 0.5f;
    
    // Control the moves
    public void move(){
        
        if(speed == 0f){
            return;
        }
            Vector2 position = transform.position;
            GameObject.Find("char_indicator").GetComponent<Transform>().position = new Vector3(position.x+0.25f,position.y+0.6f,1);
            int done = 1;
            if((Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))){
                done = 2;
            foreach(int[] block in GameManager.GameManager.blocklist){
                if(position.y == (float)block[1]/2f   && position.x-speed == (float)block[0]/2f){                  
                    done = 0;
                }
            }
            foreach(int[] block in GameManager.GameManager.walllist){
                if(position.y == (float)block[1]/2f   && position.x-speed == (float)block[0]/2f){
                    done = 0;
                }
            }
            if(position.x-speed < GameManager.GameManager.Xbound[0]){
                done = 0;
            }

            position.x -= speed;

        }
        if((Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))){
            done = 2;
            foreach(int[] block in GameManager.GameManager.blocklist){
                if(position.y == (float)block[1]/2f && position.x+speed == (float)block[0]/2f){
                    done = 0;
                }
            }
            foreach(int[] block in GameManager.GameManager.walllist){
                if(position.y == (float)block[1]/2f && position.x+speed == (float)block[0]/2f){
                    done = 0;
                }
            }
            if(position.x+speed > GameManager.GameManager.Xbound[1]){
                done = 0;
            }
            position.x += speed;
        }
        if((Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))){
            done = 2;
            foreach(int[] block in GameManager.GameManager.blocklist){
                if(position.x == (float)block[0]/2f && position.y+speed == (float)block[1]/2f){
                    done = 0;
                }
            }
            foreach(int[] block in GameManager.GameManager.walllist){
                if(position.x == (float)block[0]/2f && position.y+speed == (float)block[1]/2f){
                    done = 0;
                }
            }
            if(position.y+speed > GameManager.GameManager.Ybound[1]){
                done = 0;
            }
            position.y += speed;
            
        }
        if((Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))){
            done = 2;
            foreach(int[] block in GameManager.GameManager.blocklist){
                if(position.x == (float)block[0]/2f && position.y-speed == (float)block[1]/2f){
                    done = 0;
                }
            }
            foreach(int[] block in GameManager.GameManager.walllist){
                if(position.x == (float)block[0]/2f && position.y-speed == (float)block[1]/2f){
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
            GameObject.Find("char_indicator").GetComponent<Transform>().position = new Vector3(position.x+0.25f,position.y+0.6f,1);
            if(position.x == GameManager.GameManager.red_panda[0] && position.y == GameManager.GameManager.red_panda[1]){
                GameManager.GameManager.win++;
                speed=0f;
            }
            //Debug.Log(position.x+" : "+ position.y);
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
        
        
        
    }
}
}