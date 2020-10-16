using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour
{
    public LayerMask ground;
    int score;
    public Text scoreText; 
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

   

    public void IncreaseScore()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), out hit, 10f, ground))
        {
            GameObject groundHit = hit.collider.gameObject;

            if (groundHit.tag == "Untagged")
            {
                groundHit.tag = "hit";
                score++;
                scoreText.text = score.ToString();
                Debug.Log(groundHit);
            }
            

        }
        
        Debug.DrawRay(transform.position, -transform.up * 5f, Color.red, duration: 4f);
    }
}
