using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using TMPro;
//using UnityEditor;
using JetBrains.Annotations;
using UnityEngine.SceneManagement;

public class grid : MonoBehaviour
{
    public string GameState = "red";
    public layerCon[,,] layerS;
    public tile[,,] GriD;
    public Vector3Int gridSize;
    public tile TileS;
    public layerCon layerprefab;
    public float gridSpacing = 1.1f;
    public TextMeshProUGUI Winner;
    public TextMeshProUGUI [] aidboxes;
    //public gridSquare tilePrefab;
    void Start()
    {
        Winner.rectTransform.position = new Vector3 (1.7f,6 ,0);
        GriD = new tile[gridSize.x, gridSize.y, gridSize.z];
        //layerS = new layerCon[gridSize.x, gridSize.y,gridSize.z];
        //layerDis = new highlight[gridSize.x, gridSize.y, gridSize.z];
        for (int x = 0; x < gridSize.x; x++)
        {
            for (int y = 0; y < gridSize.y; y++)
            {
                for (int z = 0; z < gridSize.z; z++)
                {

                    tile newTileObject = Instantiate(TileS);
                    GriD[x, y, z] = newTileObject;
                    //manual location maker*GriD[0, 0, 0].transform.position = new Vector3(-7, -3.5f, 0) but how to make the other tiles take the same transformation;
                    newTileObject.parentGrid = this;
                    newTileObject.transform.parent = this.transform;
                    newTileObject.coordinates = new Vector3Int(x, y, z);
                    newTileObject.transform.localPosition = new Vector3(x * gridSpacing, y * gridSpacing, z * gridSpacing);

                }
            }
        }
        ///public int zLayer;
        // counts how many layers are in play then creates circle buttons to represent that number 
        for (int z = 0; z < gridSize.y; z++)
        {
            
            layerCon newTileObject = Instantiate(layerprefab);
            newTileObject.zLayer = z;
            newTileObject.transform.parent = this.transform;
            newTileObject.layerChecker = this;
            TurnOffLayer(z);
            newTileObject.transform.localPosition = new Vector3(-1, z, 0);
            
        }
        TurnOnLayer(0);
        // for displaying a grid infront of selected grid
    }
    private void Update()
    {
        print(Winner.rectTransform.position);
        print(Winner.rectTransform.position);
        if (GameState == "red")
        {
            Winner.text= "<color=red> Red turn </color>";
            }
        if (GameState == "blue")
        {
            Winner.text = "<color=blue> Blue turn </color>";
        }
        if (GameState == "GameOver")
        {           
            aidboxes[0].enabled = false;
            aidboxes[1].enabled = false;
            if (Input.GetKeyDown("space"))
            {
                SceneManager.LoadScene("sampleScene");
            }
        }
    }
    public int activeLayer = 0;
    public void TurnOnLayer(int zLayer)
    {
        TurnOffLayer(activeLayer);
        for (int x = 0; x < gridSize.x; x++)
        {
            for (int y = 0; y < gridSize.y; y++)
            {
                GriD[x, y, zLayer].gameObject.GetComponent<SpriteRenderer>().enabled = true;
                GriD[x, y, zLayer].gameObject.GetComponent<Collider2D>().enabled = true;
            }
        }
        
        activeLayer = zLayer;
    }
    public void TurnOffLayer(int zLayer) 
    {
        for (int x = 0; x < gridSize.x; x++)
        {
            for (int y = 0; y < gridSize.y; y++)
            {
                GriD[x, y, zLayer].gameObject.GetComponent<SpriteRenderer>().enabled =false;
                GriD[x, y, zLayer].gameObject.GetComponent<Collider2D>().enabled = false;
            }
        }
    }
    public tile GetRelativeTile(Vector3Int coordinates, Vector3Int direction)
    {
        Vector3Int gridends = coordinates + direction;

        if (gridends.x < 0) return null;
        if (gridends.y < 0) return null;
        if (gridends.z < 0) return null;
        if (gridends.x >= gridSize.x) return null;
        if (gridends.y >= gridSize.y) return null;
        if (gridends.z >= gridSize.z) return null;

        return GriD[gridends.x, gridends.y, gridends.z];
    }
    /*public layerCon GetRelativeLayer(Vector3Int layernumB, Vector3Int direction)
    {
        Vector3Int layerlimiteR = layernumB + direction;

        if (layerlimiteR.x < 0) return null;
        if (layerlimiteR.y < 0) return null;
        if (layerlimiteR.z < 0) return null;
        if (layerlimiteR.x >= gridSize.x) return null;
        if (layerlimiteR.y >= gridSize.y) return null;
        if (layerlimiteR.z >= gridSize.z) return null;

        //return layerS[layerlimiteR.x,layerlimiteR.y,layerlimiteR.z];
    }*/
}
