using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour
{
    public LayerMask ground;
    int score;
    public Text scoreText;
    public bool alive;
    
    // Start is called before the first frame update
    void Start()
    {
        alive = true;
        score = -1;
       
        


          
        
    }

    private void Update()
    {
        StartCoroutine(IncreaseScore());
    }


    private IEnumerator IncreaseScore()
    {
        RaycastHit hit;
        
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), out hit, 10f, ground))
            {
                GameObject groundHit = hit.collider.gameObject;
                Debug.Log(groundHit);
                if (groundHit.tag == "Untagged")
                {
                    groundHit.tag = "Hit";
                    score++;
                    scoreText.text = score.ToString();
                    Debug.Log(groundHit);
                }

                yield return null;
            }
        
        
        Debug.DrawRay(transform.position, -transform.up * 5f, Color.red, duration: 4f);
    }
}
