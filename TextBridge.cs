using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextBridge : MonoBehaviour
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

            

            if (hit.collider.gameObject.tag == "Bridge" )
            {
                textshown = true;
                text.text = "It's an old bridge.";
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

