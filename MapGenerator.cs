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
        Tilemap tile = GameObject.Find("Tilemap_1").GetComponent<Tilemap>();
        //Debug.Log(Resources.Load<Tile>("TestBlock"));
        foreach(int[] block in GameManager.GameManager.blocklist){
            tile.SetTile(new Vector3Int(block[0], block[1],0), Resources.Load<Tile>("TestBlock"));
        }
        foreach(int[] block in GameManager.GameManager.walllist){
            tile.SetTile(new Vector3Int(block[0], block[1],0), Resources.Load<Tile>("WallTest"));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        //Debug.Log("aaaa");
    }
}
