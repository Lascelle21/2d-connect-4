using System.Collections;
using System.Collections.Generic;
//using UnityEditor.U2D.Aseprite;
using UnityEngine;

public class highlight : MonoBehaviour
{
    public grid griD;
    public layerpointer[,] layerDis;
    public layerpointer layerDisprefab;
    public GameObject MinigridLocator;
    public tile gridRelavace;
    float spacing = 0.3f;
    // Start is called before the first frame update
    void Start()
    {
        for (int x = 0; x < griD.gridSize.x; x++)
        {
            for (int y = 0; y < griD.gridSize.y; y++)
            {
                layerpointer newTileObject = Instantiate(layerDisprefab);                
                newTileObject.Localgridspace = this;
                newTileObject.transform.parent = this.transform;
                newTileObject.Coordinates = new Vector2Int(x, y);
                newTileObject.transform.localPosition = new Vector2(x * spacing, y * spacing);
                newTileObject.crossoveR.x = x;
                newTileObject.crossoveR.y = y;
            }
        }
        //print(griD.TileS.coordinates);
    }
    public layerpointer GetRelativePoint(Vector2Int Coordinates, Vector2Int direction)
    {
        Vector2Int pointerEnd = Coordinates + direction;
        if (pointerEnd.x < 0) return null;
        if (pointerEnd.y < 0) return null;
        if (pointerEnd.x >= griD.gridSize.x) return null;
        if (pointerEnd.y >= griD.gridSize.y) return null;
        return layerDis[pointerEnd.x, pointerEnd.y];
    }
    //layerDis[x] = newTileObject;
    //newTileObject.transform.parent = this.transform;
    //newTileObject.transform.localPosition = new Vector2(MinigridLocator.transform.localPosition.x, MinigridLocator.transform.localPosition.y);//(MinigridLocator.transform.position.x*spacing, MinigridLocator.transform.position.y*spacing);
    // resume from here for front layer grid display and learn how to locate the grid in the bottom left of screen also figure out why the four in a row triggers when not the same colour.

    
    // Update is called once per frame
    void Update()
    {
        //print(this.GetRelativePoint(coordinate, Vector2Int. right));
        //print(highlight);
        
    }
}
