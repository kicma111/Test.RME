using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float FollowSpeed = 2f;
    public float panSpeed = 20f;
    public float EdgeSize = 10f;

    // Player Character
    public Transform target;

    public float yOffSet = 1f;

    // Sets the limits to which the camera may move

    [SerializeField]
    float LeftLimit;
    [SerializeField]
    float RightLimit;
    [SerializeField]
    float BottomLImit;
    [SerializeField]
    float TopLimit;


    void Update()
    {
        // Changes position of camera 
        Vector3 newPos = new Vector3(target.position.x, target.position.y + yOffSet, -10f);
        transform.position = Vector3.Slerp(transform.position, newPos, FollowSpeed * Time.deltaTime);

        transform.position = new Vector3
            (

            Mathf.Clamp(transform.position.x, LeftLimit, RightLimit),
            Mathf.Clamp(transform.position.y, BottomLImit, TopLimit),
            transform.position.z

            );

         Vector3 pos = transform.position;
        
        if(Input.mousePosition.x > Screen.width - EdgeSize)
        {
            pos.x += panSpeed * Time.deltaTime;
            transform.position = pos;
        }
        

        if (Input.mousePosition.x < EdgeSize)
        {
            pos.x -= panSpeed * Time.deltaTime;
            transform.position = pos;
        }


    }
}
