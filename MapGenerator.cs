using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameManager;
//using UnityEngine.Tilemaps;
public class MapGenerator : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        foreach(int[] block in GameManager.GameManager.blocklist){
            //Tilemap.setTile(new Vector3Int(block[0], block[1],0), Resources.Load<Tile>("TestBlock.prefab"));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
