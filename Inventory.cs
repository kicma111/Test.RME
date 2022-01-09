using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField]
    public GameObject Panel;
    public GameObject ButtonExit;

    public void OpenPanel()
    {
        if (Panel != null)
        {
            Panel.SetActive(true);
            ButtonExit.SetActive(true);
            GameObject.Find("Player").GetComponent<Movement>().moving = false;
        }
        
        
               
    }
}
