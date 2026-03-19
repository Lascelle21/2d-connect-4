using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class layerCon : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public grid layerChecker;
    public tile gridchecker;
    public int zLayer;
    //int gridRange = 7;
    public bool selecteD =false;
    public bool oveR = false;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
      //  print(layernumB);
    }

    private void Update()
    {
        if (layerChecker.GameState != "GameOver")
        {
            if (zLayer == layerChecker.activeLayer)
            {
                spriteRenderer.color = Color.green;
            }
            if (zLayer != layerChecker.activeLayer && selecteD == false)
            {
                spriteRenderer.color = Color.white;
            }
        }
    }
    // Update is called once per frame
    private void OnMouseDown()
    {
        if (layerChecker.GameState != "GameOver")
        {
            layerChecker.TurnOnLayer(zLayer);
        }
    }
    void OnMouseOver()
    {
        if (layerChecker.GameState != "GameOver")
        {
            selecteD = true;
            spriteRenderer.color = Color.grey;
        }
    }
    void OnMouseExit()
    {
        if (layerChecker.GameState != "GameOver")
        {
            selecteD = false;
            if (zLayer != layerChecker.activeLayer)
            {
                spriteRenderer.color = Color.white;
            }
        }
    }
}
