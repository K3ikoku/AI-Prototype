using UnityEngine;
using System.Collections.Generic;

public class TileMap : MonoBehaviour {

    public GameObject selectedUnit;
    public TileType[] tileTypes;
    int[,] tiles;

    [SerializeField] int mapSizeX = 10;
    [SerializeField] int mapSizeY = 10;

    void Start()
    {
        GenerateGrid();
        GeneratePathFindingGraph();
        GenerateMapVisual();


    }

    class Node
    {
        public List<Node> neightbours;

        public Node()
        {
            neightbours = new List<Node>();                
        }
    }

    Node[,] graph;



    void GeneratePathFindingGraph()
    {
        graph = new Node[mapSizeX, mapSizeY];

        for (int x = 0; x < mapSizeX; x++)
        {
            for (int y = 0; y < mapSizeY; y++)
            {
                // we have a 4 way connected map
                // this also works with 6-way hexes and 8 way tiles.
                if(x > 0)
                    graph[x, y].neightbours.Add(graph[x - 1, y]);
                if (x > mapSizeX-1)
                    graph[x, y].neightbours.Add(graph[x + 1, y]);
                if (y > 0)
                    graph[x, y].neightbours.Add(graph[x , y-1]);
                if (y > mapSizeY - 1)
                    graph[x, y].neightbours.Add(graph[x , y + 1]);
            }
        }
    }

    void GenerateMapVisual()
    {
        for (int x = 0; x < mapSizeX; x++)
        {
            for (int y = 0; y < mapSizeY; y++)
                {
                    TileType tt = tileTypes[tiles[x, y]];
                    GameObject GO = (GameObject) Instantiate(tt.tilePrefab, new Vector3(x, y, 0), Quaternion.identity);

                    Clickable CA = GO.GetComponent<Clickable>();
                CA.tileX = x;
                CA.tileY = y;
                CA.map = this;
                }
        }
    }


    void GenerateGrid()
    {
        
        // allocate our maptiles
        tiles = new int[mapSizeX, mapSizeY];

        // Initialize our map tiles
        for (int x = 0; x < mapSizeX; x++)
            {
                for (int y = 0; y < mapSizeY; y++)
                    {
                        tiles[x, y] = Mathf.RoundToInt(Random.Range(0, 3));

                    }
            }
    }

    public void MoveSelectedUnitTo(int x, int y)
    {
        //selectedUnit.transform.position= new Vector3 (x, y, 0);




    }
}
