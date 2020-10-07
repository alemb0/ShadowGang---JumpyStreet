using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    [SerializeField] private GameObject player;
    [SerializeField] private Vector3 offset;
    [SerializeField] private float smooth;
    // Start is called before the first frame update
   

    private void Update()
    {
        transform.position = Vector3.Lerp(transform.position, player.transform.position + offset, smooth);
    }


}
