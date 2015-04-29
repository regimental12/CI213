using UnityEngine;
using System.Collections;

public class World : MonoBehaviour {

    public TileTypes[] tileTypes;

    int[,] tiles;

    public int mapSizeX = 10;
    public int mapSizeY = 10;

    public int selectedUnitName = 0;

    public GameObject go; 

	// Use this for initialization
	void Start () {
        
	    generateMapData();
        generateMapVisuals();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void generateMapData()
    {
        tiles = new int[mapSizeX, mapSizeY];

        int x, y;

        // Initialize our map tiles to be grass
        for (x = 0; x < mapSizeX; x++)
        {
            for (y = 0; y < mapSizeX; y++)
            {
                tiles[x, y] = 0;
            }
        }
    }

    void generateMapVisuals()
    {
        
		for(int x=0; x < mapSizeX; x++) {
			for(int y=0; y < mapSizeX; y++) {
				TileTypes tt = tileTypes[ tiles[x,y] ];
				GameObject go = (GameObject)Instantiate( tt.tileVisualPrefab, new Vector3(x, y, 0), Quaternion.identity );

				ClickableTile ct = go.GetComponent<ClickableTile>();
				ct.tileX = x;
				ct.tileY = y;
				ct.map = this;
			}
		}
    }
}
