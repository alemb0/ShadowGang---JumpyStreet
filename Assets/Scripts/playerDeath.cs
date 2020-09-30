using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerDeath : MonoBehaviour
{
    public ParticleSystem hitDeathParticle;
    public ParticleSystem drownParticle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider hit)
    {
        if(hit.gameObject.tag == "Car")
        {
            PlayerHitDeath();
        }
        if(hit.gameObject.tag == "Water")
        {
            PlayerDrownDeath();
        }
    }

    private void PlayerHitDeath()
    {
        Instantiate(hitDeathParticle, gameObject.transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
    private void PlayerDrownDeath()
    {
        Instantiate(drownParticle, gameObject.transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
