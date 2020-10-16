using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameObject player;
    public int amountToMove;
    private Animator anim;
    private bool facingLeft;
    private bool facingRight;
    private bool facingFoward;
    private bool facingBack;
    public LayerMask ground;
    

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponentInChildren<Animator>();
        anim.SetBool("jump", false);
        facingLeft = false;
        facingRight = false;
        facingBack = false;
        facingFoward = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            gameObject.transform.parent = null;
            MovePlayerFoward();
            ParentWithTerrain();
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            gameObject.transform.parent = null;
            MovePlayerBackward();
            ParentWithTerrain();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            gameObject.transform.parent = null;
            MovePlayerRight();
            ParentWithTerrain();
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            gameObject.transform.parent = null;
            MovePlayerLeft();
            ParentWithTerrain();
        }
        
    }

    private void MovePlayerFoward()
    {
        if (facingLeft)
        {
            player.transform.position = new Vector3(player.transform.position.x + amountToMove, player.transform.position.y, player.transform.position.z );
            anim.SetBool("jump", true);
            player.transform.Rotate(0.0f, 90.0f, 0.0f, Space.Self);
        }
        if (facingRight)
        {
            player.transform.position = new Vector3(player.transform.position.x + amountToMove, player.transform.position.y, player.transform.position.z);
            anim.SetBool("jump", true);
            player.transform.Rotate(0.0f, -90.0f, 0.0f, Space.Self);
        }
        if (facingFoward)
        {
            player.transform.position = new Vector3(player.transform.position.x + amountToMove, player.transform.position.y, player.transform.position.z );
            anim.SetBool("jump", true);
        }
        if (facingBack)
        {
            player.transform.position = new Vector3(player.transform.position.x + amountToMove, player.transform.position.y, player.transform.position.z );
            anim.SetBool("jump", true);
            player.transform.Rotate(0.0f, 180.0f, 0.0f, Space.Self);
        }
        facingFoward = true;
        facingLeft = false;
        facingRight = false;
        facingBack = false;
    }
    private void MovePlayerBackward()
    {
        if (facingFoward)
        {
            player.transform.position = new Vector3(player.transform.position.x - amountToMove, player.transform.position.y, player.transform.position.z );
            player.transform.Rotate(0.0f, 180.0f, 0.0f, Space.Self);
            anim.SetBool("jump", true);
        }
        if (facingLeft)
        {
            player.transform.position = new Vector3(player.transform.position.x - amountToMove, player.transform.position.y, player.transform.position.z );
            player.transform.Rotate(0.0f, -90.0f, 0.0f, Space.Self);
            anim.SetBool("jump", true);
        }
        if (facingRight)
        {
            player.transform.position = new Vector3(player.transform.position.x - amountToMove, player.transform.position.y, player.transform.position.z );
            player.transform.Rotate(0.0f, 90.0f, 0.0f, Space.Self);
            anim.SetBool("jump", true);
        }
        if (facingBack)
        {
            player.transform.position = new Vector3(player.transform.position.x - amountToMove, player.transform.position.y, player.transform.position.z );
            anim.SetBool("jump", true);
            
        }
        facingFoward = false;
        facingLeft = false;
        facingRight = false;
        facingBack = true;
    }
    private void MovePlayerRight()
    {
        if (facingFoward)
        {
            player.transform.position = new Vector3(player.transform.position.x , player.transform.position.y , player.transform.position.z - amountToMove);
            player.transform.Rotate(0.0f, -90.0f, 0.0f, Space.Self);
            anim.SetBool("jump", true);
        }
        if (facingLeft)
        {
            player.transform.position = new Vector3(player.transform.position.x , player.transform.position.y , player.transform.position.z - amountToMove);
            player.transform.Rotate(0.0f, 180.0f, 0.0f, Space.Self);
            anim.SetBool("jump", true);
        }
        if (facingRight)
        {
            player.transform.position = new Vector3(player.transform.position.x , player.transform.position.y , player.transform.position.z - amountToMove);
            anim.SetBool("jump", true);
        }
        if (facingBack)
        {
            player.transform.position = new Vector3(player.transform.position.x , player.transform.position.y , player.transform.position.z - amountToMove);
            anim.SetBool("jump", true);
            player.transform.Rotate(0.0f, 90.0f, 0.0f, Space.Self);
        }
        facingFoward = false;
        facingLeft = false;
        facingRight = true;
        facingBack = false;
    }
    private void MovePlayerLeft()
    {
        if (facingFoward)
        {
            player.transform.position = new Vector3(player.transform.position.x , player.transform.position.y , player.transform.position.z + amountToMove);
            player.transform.Rotate(0.0f, -90.0f, 0.0f, Space.Self);
            anim.SetBool("jump", true);
        }
        if (facingLeft)
        {
            player.transform.position = new Vector3(player.transform.position.x , player.transform.position.y , player.transform.position.z + amountToMove);
            
            anim.SetBool("jump", true);
        }
        if (facingRight)
        {
            player.transform.position = new Vector3(player.transform.position.x , player.transform.position.y , player.transform.position.z + amountToMove);
            player.transform.Rotate(0.0f, 180.0f, 0.0f, Space.Self);
            anim.SetBool("jump", true);
        }
        if (facingBack)
        {
            player.transform.position = new Vector3(player.transform.position.x , player.transform.position.y , player.transform.position.z + amountToMove);
            anim.SetBool("jump", true);
            player.transform.Rotate(0.0f, 90.0f, 0.0f, Space.Self);
        }
        facingFoward = false;
        facingLeft = true;
        facingRight = false;
        facingBack = false;
    }


      public void HandleEndJump()
    {
        anim.SetBool("jump", false);
    }

    public void ParentWithTerrain()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), out hit, 5f, ground))
        {
            GameObject groundHit = hit.collider.gameObject;

            player.transform.parent = groundHit.transform;
           
        }
        Debug.DrawRay(transform.position, -transform.up * 5f, Color.red, duration: 4f);
    }
}
