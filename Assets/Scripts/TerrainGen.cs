using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainGen : MonoBehaviour
{
  
    [SerializeField] private int maxTerrainCount;
    [SerializeField] private int minDistanceFromPlayer;
    [SerializeField] private List<GameObject> terrains = new List<GameObject>();
    [SerializeField] private List<GameObject> grasses = new List<GameObject>();
    [SerializeField] private List<GameObject> roads = new List<GameObject>();


    public Transform playerPos;
    private Vector3 currentPos = new Vector3(0, 0, 0);
    private List<GameObject> currentTerrain = new List<GameObject>();
    private GameObject terrain;
    public GameObject grass;
    public GameObject road;
    private GameObject possibleTerrain;


    // Start is called before the first frame update
    void Start()
    {
        
        for(int i = 0; i < maxTerrainCount; i++)
        {
            GenerateTerrain();
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            GenerateTerrain();
        }
    }

    public void GenerateTerrain()
    {
        //road = (roads[Random.Range(0, roads.Count)]);

        if (currentPos.x - playerPos.position.x < minDistanceFromPlayer)
        {
            possibleTerrain = (terrains[Random.Range(0, terrains.Count)]);
            Debug.Log(possibleTerrain);
            if (possibleTerrain == grass)
            {
                terrain = Instantiate(grasses[Random.Range(0, grasses.Count)], currentPos, Quaternion.identity);
                currentTerrain.Add(terrain);
            }
            if (possibleTerrain == road)
            {
                terrain = Instantiate(roads[Random.Range(0, 2)], currentPos, Quaternion.identity);
                currentTerrain.Add(terrain);
            }
            else 
            {
                terrain = Instantiate(terrains[1], currentPos, Quaternion.identity);
            }
            currentTerrain.Add(terrain);


            if (currentTerrain.Count > maxTerrainCount)
            {
                Destroy(currentTerrain[0]);
                currentTerrain.RemoveAt(0);
            }
            currentPos.x++;
        }

        
    }
}
