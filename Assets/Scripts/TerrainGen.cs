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
    [SerializeField] private List<GameObject> waters = new List<GameObject>();


    public Transform playerPos;
    private Vector3 currentPos = new Vector3(0, 0, 0);
    private List<GameObject> currentTerrain = new List<GameObject>();
    private GameObject terrain;
    [SerializeField] private GameObject grass;
    [SerializeField] private GameObject road;
    [SerializeField] private GameObject water;
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

        if (currentPos.x - playerPos.position.x < minDistanceFromPlayer)
        {
           
            possibleTerrain = (terrains[Random.Range(0, terrains.Count)]);

            if (possibleTerrain == grass)
            {
                terrain = Instantiate(grasses[Random.Range(0, grasses.Count)], currentPos, Quaternion.identity);
                currentTerrain.Add(terrain);
            }
            else if (possibleTerrain == road)
            {
                terrain = Instantiate(roads[Random.Range(0, 2)], currentPos, Quaternion.identity);
                currentTerrain.Add(terrain);
            }
            else if (possibleTerrain == water)
            {
                terrain = Instantiate(waters[Random.Range(0, 2)], currentPos, Quaternion.identity);
                currentTerrain.Add(terrain);
            }
            
            

            Debug.Log(currentTerrain.Count);
            if (currentTerrain.Count > maxTerrainCount)
            {
                Destroy(currentTerrain[0]);
                currentTerrain.RemoveAt(0);
            }
            currentPos.x++;

           
        }

        
    }
}
