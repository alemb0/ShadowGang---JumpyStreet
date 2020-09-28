using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMovement : MonoBehaviour
{
    [SerializeField] private bool facingLeft;
    [SerializeField] private bool facingRight;
    [SerializeField] private float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (facingLeft)
        {
            transform.Translate(new Vector3(0, 1, 0) * speed * Time.deltaTime);
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
