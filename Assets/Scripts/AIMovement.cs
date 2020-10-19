using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMovement : MonoBehaviour
{
    [SerializeField] public bool facingLeft;
    [SerializeField] public bool facingRight;
    [SerializeField] private float speed;
    [SerializeField] private bool isLog;
    // Start is called before the first frame update
    void Start()
    {
        if (isLog == true)
        {
            speed = Random.Range(5, 6);
        }
    }

    // Update is called once per frame
    void Update()
    {
       
        if (facingLeft)
        {
            transform.Translate(new Vector3(0, 1, 0) * -speed * Time.deltaTime);
        }
        else if (facingRight)
        {
            transform.Translate(new Vector3(0, 1, 0) * -speed * Time.deltaTime);
        }

        if (transform.position.z < -30)
        {
            Destroy(this.gameObject);
        }

        if (transform.position.z > 30)
        {
            Destroy(this.gameObject);
        }

        

    }
}
