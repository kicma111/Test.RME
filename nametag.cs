using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nametag : MonoBehaviour
{
    [SerializeField]
    public GameObject target;


    private void Start()
    {
        target.SetActive(false);
    }

    void OnMouseEnter()
    {
        target.SetActive(true);

    }

    private void OnMouseExit()
    {
        target.SetActive(false);
    }

}
