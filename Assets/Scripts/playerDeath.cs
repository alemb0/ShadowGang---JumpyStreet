﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerDeath : MonoBehaviour
{
    public ParticleSystem hitDeathParticle;
    public ParticleSystem drownParticle;
    public ScoreKeeper scoreScript;

    private void OnTriggerEnter(Collider hit)
    {
        if(hit.gameObject.tag == "Car")
        {
            PlayerHitDeath();
            scoreScript.alive = false;
        }
        if(hit.gameObject.tag == "Water")
        {
            PlayerDrownDeath();
            scoreScript.alive = false;
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
