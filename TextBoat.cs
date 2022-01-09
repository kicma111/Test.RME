using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextBoat : MonoBehaviour
{
    [SerializeField]
    public TextMeshProUGUI text;
    public bool textshown;






    private void Start()
    {
        textshown = false;
    }

    private void Update()
    {


        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);



            if (hit.collider.gameObject.tag == "Boat")
            {
                textshown = true;
                text.text = "It's a boat, I can't reach it.";
                StartCoroutine(WaitForSec());
            }


            IEnumerator WaitForSec()
            {
                yield return new WaitForSeconds(4);
                textshown = false;
                text.text = " ";
            }

        }


    }


}

