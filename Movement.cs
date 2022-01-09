using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Movement : MonoBehaviour
{
    [SerializeField]
    public GameObject Player;
    public float speed = 10f;
    public bool moving;
    public Vector2 lastClickedPos;
    public Animator animator;
    public RaycastHit2D hit;
    [SerializeField]
    public GameObject DialogueBox;
    




    





    private void Update()
    {
        hit = Physics2D.Raycast(lastClickedPos, Vector2.zero);

        // Movement

        if (Input.GetMouseButtonDown(0))
        {
            lastClickedPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            moving = true;

        }
        if (moving && (Vector2)transform.position != lastClickedPos && hit.collider.gameObject.tag == "Area"   )
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, lastClickedPos, step);
            animator.SetBool("IsMoving", true);

            float ScaleValue = 2 - (Player.transform.position.y / 200);
            Player.transform.localScale = new Vector3(ScaleValue, ScaleValue, ScaleValue);
            
            
        }

        else
        {
            moving = false;
            animator.SetBool("IsMoving", false);
            
        }

        

        

     

        // Animation

        if ( lastClickedPos.x > transform.position.x)
        {
            animator.SetFloat("Horizontal", 1);
        }
        else if (lastClickedPos.x < transform.position.x)
        {
            animator.SetFloat("Horizontal", 0);
        }
        


       
       
        

        

        





    }
}
