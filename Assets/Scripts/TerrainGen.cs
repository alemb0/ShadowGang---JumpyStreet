using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainGen : MonoBehaviour
{
  
    [SerializeField] private int maxTerrainCount;
    [SerializeField] private List<GameObject> terrains = new List<GameObject>();

    private Vector3 currentPos = new Vector3(0, 0, 0);
    private List<GameObject> currentTerrain = new List<GameObject>();
    private GameObject terrain;

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

    private void GenerateTerrain()
    {
        terrain = Instantiate(terrains[Random.Range(0, terrains.Count)], currentPos, Quaternion.identity);
        currentTerrain.Add(terrain);
        if(currentTerrain.Count > maxTerrainCount)
        {
            Destroy(currentTerrain[0]);
            currentTerrain.RemoveAt(0);
        }
        currentPos.x++;
    }
}
