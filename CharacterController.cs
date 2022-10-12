using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameManager;

public class CharacterController : MonoBehaviour
{
    public int speed = 1;
    
    // Control the moves
    void move(){
        
        Vector2 position = transform.position;
        if(Input.GetKeyDown(KeyCode.A)){
            foreach(int[] block in GameManager.GameManager.blocklist){
                if(position.y == block[1] && position.x-speed == block[0]){
                    return;
                }
            }
            position.x -= speed;
        }
        if(Input.GetKeyDown(KeyCode.D)){
            foreach(int[] block in GameManager.GameManager.blocklist){
                if(position.y == block[1] && position.x+speed == block[0]){
                    return;
                }
            }
            position.x += speed;
        }
        if(Input.GetKeyDown(KeyCode.W)){
            foreach(int[] block in GameManager.GameManager.blocklist){
                if(position.x == block[0] && position.y+speed == block[1]){
                    return;
                }
            }
            position.y += speed;
        }
        if(Input.GetKeyDown(KeyCode.S)){
            foreach(int[] block in GameManager.GameManager.blocklist){
                if(position.x == block[0] && position.y-speed == block[1]){
                    return;
                }
            }
            position.y -= speed;
        }
        transform.position = position;
        Debug.Log(position.x+"\n"+position.y);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        move();
        
        
    }
}
