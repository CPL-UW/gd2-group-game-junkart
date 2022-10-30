using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameManager;
using UnityEngine.Tilemaps;
//using UnityEngine.Tilemaps;
public class MapGenerator : MonoBehaviour
{
    
    // Start is called before the first frame update
    


    void Start()
    {

    }

    

    // Update is called once per frame
    void Update()
    {
        Tilemap tile = GameObject.Find("Tilemap_1").GetComponent<Tilemap>();
        for(int i = GameManager.GameManager.Xbound[0]; i <= GameManager.GameManager.Xbound[1]; i++){
            for(int j = GameManager.GameManager.Ybound[0]; j <= GameManager.GameManager.Ybound[1]; j++){
                tile.SetTile(new Vector3Int(i, j, 0),Resources.Load<Tile>("Bricks"));
            }
        }
        // foreach(int[] block in GameManager.GameManager.originBlock){
        //     tile.SetTile(new Vector3Int(block[0], block[1], 0), Resources.Load<Tile>("WallTest"));
        // }
        foreach(int[] block in GameManager.GameManager.walllist){
            tile.SetTile(new Vector3Int(block[0], block[1], 0), Resources.Load<Tile>("WallTest"));
        }
        foreach(int[] block in GameManager.GameManager.blocklist){
            //switch(block[2]){
                //case 0:
                    //tile.SetTile(new Vector3Int(block[0], block[1],0), Resources.Load<Tile>("REDBLOCK"));
                    //break;
                //case 1:
                    //tile.SetTile(new Vector3Int(block[0], block[1],0), Resources.Load<Tile>("PINKBLOCK"));
                    //break;
                //case 2:
                    //tile.SetTile(new Vector3Int(block[0], block[1],0), Resources.Load<Tile>("GREENBLOCK"));
                    //break;
                //case 3:
                    //tile.SetTile(new Vector3Int(block[0], block[1],0), Resources.Load<Tile>("YELLOWBLOCK"));
                    //break;
            //}
            tile.SetTile(new Vector3Int(block[0], block[1], 0), Resources.Load<Tile>("TestBlock"));
            
        }

        //Debug.Log("aaaa");
    }
}
