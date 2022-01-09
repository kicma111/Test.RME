using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryClose : MonoBehaviour
{
    [SerializeField]
    public GameObject panel;
    public GameObject Button;

    public void ClosePanel()
    {
        if (panel.activeSelf)
        {
            panel.SetActive(false);
            Button.SetActive(false);
        }
    }
}
