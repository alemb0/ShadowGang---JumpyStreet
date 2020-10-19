using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleSpawner : MonoBehaviour
{
    [SerializeField] private List<GameObject> vehicles = new List<GameObject>();
    [SerializeField] private GameObject vehicle;
    [SerializeField] private Transform spawnPosition;
    [SerializeField] private bool rightSideSpawn;
    [SerializeField] private float mintime;
    [SerializeField] private float maxtime;


    private int spawnRotation;
    public bool left;
    public bool right;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnVehicle());
        
    }


    private IEnumerator SpawnVehicle()
    {
        while (true)
        {
            Debug.Log(mintime);
            Debug.Log(maxtime);
            yield return new WaitForSeconds(Random.Range(2.0f, 4f));
            spawnRotation = Random.Range(0, 2);
          
            if (!rightSideSpawn)
            {
                GameObject vhl = Instantiate(vehicles[Random.Range(0, vehicles.Count)], spawnPosition.position, Quaternion.Euler(-90, 0,-180));
                vhl.GetComponent<AIMovement>().facingLeft = true;

            }
            else
            {
                GameObject vhl = Instantiate(vehicles[Random.Range(0, vehicles.Count)], spawnPosition.position, Quaternion.Euler(-90, 0, 0));
                vhl.GetComponent<AIMovement>().facingRight = true;
            }
           
        }
        
       
    }
}
