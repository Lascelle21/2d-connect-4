using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
//using UnityEditor.EditorTools;
//using UnityEditor.U2D.Aseprite;
using UnityEngine;

public class layerpointer : MonoBehaviour
{
    SpriteRenderer gridColour;
    public grid maiNs;
    public highlight Localgridspace;
    public Vector2Int Coordinates;
    public tile mainGrid;
    public GameObject tileobject;
    public Vector3Int crossoveR;
    // Start is called before the first frame update
    void Start()
    {
       // print(Localgridspace.tag);
        //print(crossoveR+"dddd");
        //print(GetComponentInParent<GameObject>().tag);
        maiNs = Localgridspace.griD;
        //maiNs.GriD[0,0,0].gameObject.SetActive(false);
        gridColour = GetComponent<SpriteRenderer>();
        gridColour.color = Color.white;

        //print(maiNs.TileS.coordinates);
        //print(Coordinates);
    }

    // Update is called once per frame
    void Update()
    {

        if (Localgridspace.tag == "nextLayer" && maiNs.activeLayer <= 3 && maiNs.activeLayer >= 0)
        {
            gridColour.enabled = true;
            if (Coordinates == (Vector2Int)crossoveR && maiNs.GriD[Coordinates.x, Coordinates.y, maiNs.activeLayer + 1].setcolouR == Color.red)
            {
                gridColour.color = Color.red;
            }
            if (Coordinates == (Vector2Int)crossoveR && maiNs.GriD[Coordinates.x, Coordinates.y, maiNs.activeLayer + 1].setcolouR == Color.blue)
            {
                gridColour.color = Color.blue;
            }
            if (Coordinates == (Vector2Int)crossoveR && maiNs.GriD[Coordinates.x, Coordinates.y, maiNs.activeLayer + 1].setcolouR == Color.white)
            {
                gridColour.color = Color.white;
            }
        }

        if (Localgridspace.tag == "nextLayer" && maiNs.activeLayer == 4)
        {
            gridColour.enabled = false;
        }
            if (Localgridspace.tag=="previousLayer" && maiNs.activeLayer <= 4 && maiNs.activeLayer >= 1)
        {
            gridColour.enabled = true;
            if (Coordinates == (Vector2Int)crossoveR && maiNs.GriD[Coordinates.x, Coordinates.y, maiNs.activeLayer - 1].setcolouR == Color.red)
            {
                gridColour.color = Color.red;
            }
            if (Coordinates == (Vector2Int)crossoveR && maiNs.GriD[Coordinates.x, Coordinates.y, maiNs.activeLayer - 1].setcolouR == Color.blue)
            {
                gridColour.color = Color.blue;
            }
            if (Coordinates == (Vector2Int)crossoveR && maiNs.GriD[Coordinates.x, Coordinates.y, maiNs.activeLayer - 1].setcolouR == Color.white)
            {
                gridColour.color = Color.white;
            }
        }
        if (Localgridspace.tag == "previousLayer" && maiNs.activeLayer == 0)
        {
            gridColour.enabled = false;
        }
        if (maiNs.GameState== "GameOver")
        {
            gameObject.SetActive(false);
        }
                
        }
        
        /*if (maiNs.GriD[0,0,0].GetComponent<SpriteRenderer>().color != Color.white)
        {
            Localgridspace.layerDis[0, 0].GetComponent<SpriteRenderer>().color = maiNs.GriD[0, 0, 0].GetComponent<tile>().setcolouR; 
        }
        */
        //print(Coordinates); how to find main grid grid coordinates but need to learn how to comunicate spesifics 
}

