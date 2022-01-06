using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Movement : MonoBehaviour
{
    public float speed = 10f;
    public bool moving;
    Vector2 lastClickedPos;
    public Animator animator;
    RaycastHit2D hit;

   

    


    private void Update()
    {
        hit = Physics2D.Raycast(lastClickedPos, Vector2.zero);

        if (Input.GetMouseButtonDown(0))
        {
            lastClickedPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            moving = true;

        }
        if (moving && (Vector2)transform.position != lastClickedPos && hit.collider.gameObject.tag == "Area")
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, lastClickedPos, step);
            animator.SetBool("IsMoving", true);
            animator.SetFloat("Horizontal", transform.position.x);




        }
        else
        {
            moving = false;
            animator.SetBool("IsMoving", false);
        }

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
