using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public CanvasGroup inventoryCG;
    // Start is called before the first frame update
    void Start()
    {
        OnInventoryOpen(true);
    }

    public void OnInventoryOpen(bool isOpened)
    {
        inventoryCG.alpha = (isOpened) ? 1.0f : 0.0f;
        inventoryCG.interactable = isOpened;
        inventoryCG.blocksRaycasts = isOpened;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
