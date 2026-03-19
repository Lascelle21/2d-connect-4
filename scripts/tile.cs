using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class tile : MonoBehaviour
{
    public grid parentGrid;
    public Vector3Int coordinates;
    SpriteRenderer spriteRenderer;
    public string gridState = "white";
    BoxCollider2D collideR;
    public Color setcolouR;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer= GetComponent<SpriteRenderer>();
        setcolouR = Color.white;

    }

    // Update is called once per frame
    void Update()
    {
    
    }
    void OnMouseDown()
    {
        if (parentGrid.GameState != "GameOver")
        {
            if (parentGrid.GameState == "red" && spriteRenderer.color == Color.gray)
            {
                setcolouR = Color.red;
                spriteRenderer.color = setcolouR;
                parentGrid.GameState = "blue";
            }
            if (parentGrid.GameState == "blue" && spriteRenderer.color == Color.gray)
            {
                setcolouR = Color.blue;
                spriteRenderer.color = setcolouR;
                parentGrid.GameState = "red";
            }
            if (spriteRenderer.color == Color.red)
            {
                gridState = "red";
            }
            if (spriteRenderer.color == Color.blue)
            {
                gridState = "blue";
            }
            int isBlue = 0;
            int isRed =0;

            if( gridState == "blue")
            {
                isBlue = 1;
;           }
            else
            {
                isRed = 1;
            }
            int diaganalRightleft = isRed;
            int diaganalLeftRight = isRed;
            int leftRightcounter = isRed;
            int forwardBackcounter = isRed;
            int upDowncounter = isRed;
            int frontleftright = isRed;
            int backleftright = isRed;
            int diaganalBackRightLeft = isRed;
            int diaganalBackLeftRight = isRed;
            int vecticalBackFornt = isRed;
            int vecticalForntBack = isRed;
            // blue 

            int BdiaganalRightleft = isBlue;
            int BdiaganalLeftRight = isBlue;
            int BleftRightcounter = isBlue;
            int BforwardBackcounter = isBlue;
            int BupDowncounter = isBlue;
            int Bfrontleftright = isBlue;
            int Bbackleftright = isBlue;
            int BdiaganalBackRightLeft = isBlue;
            int BdiaganalBackLeftRight = isBlue;
            int bvecticalBackFornt = isBlue;
            int bvecticalForntBack = isBlue;


            tile left1 = parentGrid.GetRelativeTile(coordinates, Vector3Int.left);
            if (left1 != null && left1.gridState == "red")
            {
                leftRightcounter += 1;
                tile left2 = parentGrid.GetRelativeTile(coordinates, Vector3Int.left * 2);
                if (left2 != null && left2.gridState == "red")
                {
                    leftRightcounter += 1;
                    tile left3 = parentGrid.GetRelativeTile(coordinates, Vector3Int.left * 3);
                    if (left3 != null && left3.gridState == "red")
                    {
                        leftRightcounter += 1;
                    }
                }
            }
            if (left1 != null && left1.gridState == "blue")
            {
                BleftRightcounter += 1;
                tile left2 = parentGrid.GetRelativeTile(coordinates, Vector3Int.left * 2);
                if (left2 != null && left2.gridState == "blue")
                {
                    BleftRightcounter += 1;
                    tile left3 = parentGrid.GetRelativeTile(coordinates, Vector3Int.left * 3);
                    if (left3 != null && left3.gridState == "blue")
                    {
                        BleftRightcounter += 1;
                    }
                }
            }
            tile right1 = parentGrid.GetRelativeTile(coordinates, Vector3Int.right);
            if (right1 != null && right1.gridState == "red")
            {
                leftRightcounter += 1;
                tile right2 = parentGrid.GetRelativeTile(coordinates, Vector3Int.right * 2);
                if (right2 != null && right2.gridState == "red")
                {
                    leftRightcounter += 1;
                    tile right3 = parentGrid.GetRelativeTile(coordinates, Vector3Int.right * 3);
                    if (right3 != null && right3.gridState == "red")
                    {
                        leftRightcounter += 1;
                    }
                }
            }
            if (right1 != null && right1.gridState == "blue")
            {
                BleftRightcounter += 1;
                tile right2 = parentGrid.GetRelativeTile(coordinates, Vector3Int.right * 2);
                if (right2 != null && right2.gridState == "blue")
                {
                    BleftRightcounter += 1;
                    tile right3 = parentGrid.GetRelativeTile(coordinates, Vector3Int.right * 3);
                    if (right3 != null && right3.gridState == "blue")
                    {
                        BleftRightcounter += 1;
                    }
                }
            }
            tile up1 = parentGrid.GetRelativeTile(coordinates, Vector3Int.up);
            if (up1 != null && up1.gridState == "red")
            {
                upDowncounter += 1;
                tile up2 = parentGrid.GetRelativeTile(coordinates, Vector3Int.up * 2);
                if (up2 != null && up2.gridState == "red")
                {
                    upDowncounter += 1;
                    tile up3 = parentGrid.GetRelativeTile(coordinates, Vector3Int.up * 3);
                    if (up3 != null && up3.gridState == "red")
                    {
                        upDowncounter += 1;
                    }
                }
            }
            if (up1 != null && up1.gridState == "blue")
            {
                BupDowncounter += 1;
                tile up2 = parentGrid.GetRelativeTile(coordinates, Vector3Int.up * 2);
                if (up2 != null && up2.gridState == "blue")
                {
                    BupDowncounter += 1;
                    tile up3 = parentGrid.GetRelativeTile(coordinates, Vector3Int.up * 3);
                    if (up3 != null && up3.gridState == "blue")
                    {
                        BupDowncounter += 1;
                    }
                }
            }
            tile down1 = parentGrid.GetRelativeTile(coordinates, Vector3Int.down);
            if (down1 != null && down1.gridState == "red")
            {
                upDowncounter += 1;
                tile down2 = parentGrid.GetRelativeTile(coordinates, Vector3Int.down * 2);
                if (down2 != null && down2.gridState == "red")
                {
                    upDowncounter += 1;
                    tile down3 = parentGrid.GetRelativeTile(coordinates, Vector3Int.down * 3);
                    if (down3 != null && down3.gridState == "red")
                    {
                        upDowncounter += 1;
                    }
                }
            }
            if (down1 != null && down1.gridState == "blue")
            {
                BupDowncounter += 1;
                tile down2 = parentGrid.GetRelativeTile(coordinates, Vector3Int.down * 2);
                if (down2 != null && down2.gridState == "blue")
                {
                    BupDowncounter += 1;
                    tile down3 = parentGrid.GetRelativeTile(coordinates, Vector3Int.down * 3);
                    if (down3 != null && down3.gridState == "blue")
                    {
                        BupDowncounter += 1;
                    }
                }
            }

            tile back1 = parentGrid.GetRelativeTile(coordinates, Vector3Int.back);
            if (back1 != null && back1.gridState == "red")
            {
                forwardBackcounter += 1;
                tile back2 = parentGrid.GetRelativeTile(coordinates, Vector3Int.back * 2);
                if (back2 != null && back2.gridState == "red")
                {
                    forwardBackcounter += 1;
                    tile back3 = parentGrid.GetRelativeTile(coordinates, Vector3Int.back * 3);
                    if (back3 != null && back3.gridState == "red")
                    {
                        forwardBackcounter += 1;
                    }
                }
            }
            if (back1 != null && back1.gridState == "blue")
            {
                BforwardBackcounter += 1;
                tile back2 = parentGrid.GetRelativeTile(coordinates, Vector3Int.back * 2);
                if (back2 != null && back2.gridState == "blue")
                {
                    BforwardBackcounter += 1;
                    tile back3 = parentGrid.GetRelativeTile(coordinates, Vector3Int.back * 3);
                    if (back3 != null && back3.gridState == "blue")
                    {
                        BforwardBackcounter += 1;
                    }
                }
            }
            tile forward1 = parentGrid.GetRelativeTile(coordinates, Vector3Int.forward);
            if (forward1 != null && forward1.gridState == "red")
            {
                forwardBackcounter += 1;
                tile forward2 = parentGrid.GetRelativeTile(coordinates, Vector3Int.forward * 2);
                if (forward2 != null && forward2.gridState == "red")
                {
                    forwardBackcounter += 1;
                    tile forward3 = parentGrid.GetRelativeTile(coordinates, Vector3Int.forward * 3);
                    if (forward3 != null && forward3.gridState == "red")
                    {
                        forwardBackcounter += 1;
                    }
                }
            }
            if (forward1 != null && forward1.gridState == "blue")
            {
                BforwardBackcounter += 1;
                tile forward2 = parentGrid.GetRelativeTile(coordinates, Vector3Int.forward * 2);
                if (forward2 != null && forward2.gridState == "blue")
                {
                    BforwardBackcounter += 1;
                    tile forward3 = parentGrid.GetRelativeTile(coordinates, Vector3Int.forward * 3);
                    if (forward3 != null && forward3.gridState == "blue")
                    {
                        BforwardBackcounter += 1;
                    }
                }
            }

            tile upleft1 = parentGrid.GetRelativeTile(coordinates, Vector3Int.up + Vector3Int.left);
            if (upleft1 != null && upleft1.gridState == "red")
            {
                diaganalLeftRight += 1;
                tile upleft2 = parentGrid.GetRelativeTile(coordinates, Vector3Int.up * 2 + Vector3Int.left * 2);
                if (upleft2 != null && upleft2.gridState == "red")
                {
                    diaganalLeftRight += 1;
                }
                tile upleft3 = parentGrid.GetRelativeTile(coordinates, Vector3Int.up * 3 + Vector3Int.left * 3);
                if (upleft3 != null && upleft3.gridState == "red")
                {
                    diaganalLeftRight += 1;
                }
            }
            if (upleft1 != null && upleft1.gridState == "blue")
            {
                BdiaganalLeftRight += 1;
                tile upleft2 = parentGrid.GetRelativeTile(coordinates, Vector3Int.up * 2 + Vector3Int.left * 2);
                if (upleft2 != null && upleft2.gridState == "blue")
                {
                    BdiaganalLeftRight += 1;
                }
                tile upleft3 = parentGrid.GetRelativeTile(coordinates, Vector3Int.up * 3 + Vector3Int.left * 3);
                if (upleft3 != null && upleft3.gridState == "blue")
                {
                    BdiaganalLeftRight += 1;
                }
            }
            tile downright1 = parentGrid.GetRelativeTile(coordinates, Vector3Int.down + Vector3Int.right);
            if (downright1 != null && downright1.gridState == "red")
            {
                diaganalLeftRight += 1;
                tile downright2 = parentGrid.GetRelativeTile(coordinates, Vector3Int.down * 2 + Vector3Int.right * 2);
                if (downright2 != null && downright2.gridState == "red")
                {
                    diaganalLeftRight += 1;
                    tile downright3 = parentGrid.GetRelativeTile(coordinates, Vector3Int.down * 3 + Vector3Int.right * 3);
                    if (downright3 != null && downright3.gridState == "red")
                    {
                        diaganalLeftRight += 1;
                    }
                }
            }
            if (downright1 != null && downright1.gridState == "blue")
            {
                BdiaganalLeftRight += 1;
                tile downright2 = parentGrid.GetRelativeTile(coordinates, Vector3Int.down * 2 + Vector3Int.right * 2);
                if (downright2 != null && downright2.gridState == "blue")
                {
                    BdiaganalLeftRight += 1;
                    tile downright3 = parentGrid.GetRelativeTile(coordinates, Vector3Int.down * 3 + Vector3Int.right * 3);
                    if (downright3 != null && downright3.gridState == "blue")
                    {
                        BdiaganalLeftRight += 1;
                    }
                }
            }
            tile upright1 = parentGrid.GetRelativeTile(coordinates, Vector3Int.up + Vector3Int.right);
            if (upright1 != null && upright1.gridState == "red")
            {
                diaganalRightleft += 1;
                tile upright2 = parentGrid.GetRelativeTile(coordinates, Vector3Int.up * 2 + Vector3Int.right * 2);
                if (upright2 != null && upright2.gridState == "red")
                {
                    diaganalRightleft += 1;
                    tile upright3 = parentGrid.GetRelativeTile(coordinates, Vector3Int.up * 3 + Vector3Int.right * 3);
                    if (upright3 != null && upright3.gridState == "red")
                    {
                        diaganalRightleft += 1;
                    }
                }
            }
            if (upright1 != null && upright1.gridState == "blue")
            {
                BdiaganalRightleft += 1;
                tile upright2 = parentGrid.GetRelativeTile(coordinates, Vector3Int.up * 2 + Vector3Int.right * 2);
                if (upright2 != null && upright2.gridState == "blue")
                {
                    BdiaganalRightleft += 1;
                    tile upright3 = parentGrid.GetRelativeTile(coordinates, Vector3Int.up * 3 + Vector3Int.right * 3);
                    if (upright3 != null && upright3.gridState == "blue")
                    {
                        BdiaganalRightleft += 1;
                    }
                }
            }
            tile downleft1 = parentGrid.GetRelativeTile(coordinates, Vector3Int.down + Vector3Int.left);
            if (downleft1 != null && downleft1.gridState == "red")
            {
                diaganalRightleft += 1;
                tile downleft2 = parentGrid.GetRelativeTile(coordinates, Vector3Int.down * 2 + Vector3Int.left * 2);
                if (downleft2 != null && downleft2.gridState == "red")
                {
                    diaganalRightleft += 1;
                    tile downleft3 = parentGrid.GetRelativeTile(coordinates, Vector3Int.down * 3 + Vector3Int.left * 3);
                    if (downleft3 != null && downleft3.gridState == "red")
                    {
                        diaganalRightleft += 1;
                    }
                }
            }
            if (downleft1 != null && downleft1.gridState == "blue")
            {
                BdiaganalRightleft += 1;
                tile downleft2 = parentGrid.GetRelativeTile(coordinates, Vector3Int.down * 2 + Vector3Int.left * 2);
                if (downleft2 != null && downleft2.gridState == "blue")
                {
                    BdiaganalRightleft += 1;
                    tile downleft3 = parentGrid.GetRelativeTile(coordinates, Vector3Int.down * 3 + Vector3Int.left * 3);
                    if (downleft3 != null && downleft3.gridState == "blue")
                    {
                        BdiaganalRightleft += 1;
                    }
                }
            }
            tile frontleft1 = parentGrid.GetRelativeTile(coordinates, Vector3Int.forward + Vector3Int.left);
            if (frontleft1 != null && frontleft1.gridState == "red")
            {
                frontleftright += 1;
                tile frontleft2 = parentGrid.GetRelativeTile(coordinates, Vector3Int.forward * 2 + Vector3Int.left * 2);
                if (frontleft2 != null && frontleft1.gridState == "red")
                {
                    frontleftright += 1;
                    tile fronttleft3 = parentGrid.GetRelativeTile(coordinates, Vector3Int.forward * 3 + Vector3Int.left * 3);
                    if (fronttleft3 != null && fronttleft3.gridState == "red")
                    {
                        frontleftright += 1;
                    }
                }
            }
            if (frontleft1 != null && frontleft1.gridState == "blue")
            {
                Bfrontleftright += 1;
                tile frontleft2 = parentGrid.GetRelativeTile(coordinates, Vector3Int.forward * 2 + Vector3Int.left * 2);
                if (frontleft2 != null && frontleft1.gridState == "blue")
                {
                    Bfrontleftright += 1;
                    tile fronttleft3 = parentGrid.GetRelativeTile(coordinates, Vector3Int.forward * 3 + Vector3Int.left * 3);
                    if (fronttleft3 != null && fronttleft3.gridState == "blue")
                    {
                        Bfrontleftright += 1;
                    }
                }
            }
            tile backright1 = parentGrid.GetRelativeTile(coordinates, Vector3Int.back + Vector3Int.right);
            if (backright1 != null && backright1.gridState == "red")
            {
                frontleftright += 1;
                tile backright2 = parentGrid.GetRelativeTile(coordinates, Vector3Int.back * 2 + Vector3Int.right * 2);
                if (backright2 != null && backright2.gridState == "red")
                {
                    frontleftright += 1;
                    tile backright3 = parentGrid.GetRelativeTile(coordinates, Vector3Int.back * 3 + Vector3Int.right * 3);
                    if (backright3 != null && backright3.gridState == "red")
                    {
                        frontleftright += 1;
                    }
                }
            }
            if (backright1 != null && backright1.gridState == "blue")
            {
                Bfrontleftright += 1;
                tile backright2 = parentGrid.GetRelativeTile(coordinates, Vector3Int.back * 2 + Vector3Int.right * 2);
                if (backright2 != null && backright2.gridState == "blue")
                {
                    Bfrontleftright += 1;
                    tile backright3 = parentGrid.GetRelativeTile(coordinates, Vector3Int.back * 3 + Vector3Int.right * 3);
                    if (backright3 != null && backright3.gridState == "blue")
                    {
                        Bfrontleftright += 1;
                    }
                }
            }
            tile backleft1 = parentGrid.GetRelativeTile(coordinates, Vector3Int.back + Vector3Int.left);
            if (backleft1 != null && backleft1.gridState == "red")
            {
                backleftright += 1;
                tile backleft2 = parentGrid.GetRelativeTile(coordinates, Vector3Int.back * 2 + Vector3Int.left * 2);
                if (backleft2 != null && backleft2.gridState == "red")
                {
                    backleftright += 1;
                    tile backleft3 = parentGrid.GetRelativeTile(coordinates, Vector3Int.back * 3 + Vector3Int.left * 3);
                    if (backleft3 != null && backleft3.gridState == "red")
                    {
                        backleftright += 1;

                    }
                }
            }
            if (backleft1 != null && backleft1.gridState == "blue")
            {
                Bbackleftright += 1;
                tile backleft2 = parentGrid.GetRelativeTile(coordinates, Vector3Int.back * 2 + Vector3Int.left * 2);
                if (backleft2 != null && backleft2.gridState == "blue")
                {
                    Bbackleftright += 1;
                    tile backleft3 = parentGrid.GetRelativeTile(coordinates, Vector3Int.back * 3 + Vector3Int.left * 3);
                    if (backleft3 != null && backleft3.gridState == "blue")
                    {
                        Bbackleftright += 1;

                    }
                }
            }
            tile frontright1 = parentGrid.GetRelativeTile(coordinates, Vector3Int.forward + Vector3Int.right);
            if (frontright1 != null && frontright1.gridState == "red")
            {
                backleftright += 1;
                tile frontright2 = parentGrid.GetRelativeTile(coordinates, Vector3Int.forward * 2 + Vector3Int.right * 2);
                if (frontright2 != null && frontright2.gridState == "red")
                {
                    backleftright += 1;
                    tile frontright3 = parentGrid.GetRelativeTile(coordinates, Vector3Int.forward * 3 + Vector3Int.right * 3);
                    if (frontright3 != null && frontright3.gridState == "red")
                    {
                        backleftright += 1;
                    }
                }
            }
            if (frontright1 != null && frontright1.gridState == "blue")
            {
                Bbackleftright += 1;
                tile frontright2 = parentGrid.GetRelativeTile(coordinates, Vector3Int.forward * 2 + Vector3Int.right * 2);
                if (frontright2 != null && frontright2.gridState == "blue")
                {
                    Bbackleftright += 1;
                    tile frontright3 = parentGrid.GetRelativeTile(coordinates, Vector3Int.forward * 3 + Vector3Int.right * 3);
                    if (frontright3 != null && frontright3.gridState == "blue")
                    {
                        Bbackleftright += 1;
                    }
                }
            }

            //altered
            tile backrightup1 = parentGrid.GetRelativeTile(coordinates, Vector3Int.right + Vector3Int.up + Vector3Int.forward);
            if (backrightup1 != null && backrightup1.gridState == "red")
            {               
                diaganalBackRightLeft += 1;
                tile backrightup2 = parentGrid.GetRelativeTile(coordinates, Vector3Int.forward *2 + Vector3Int.right *2 + Vector3Int.up *2);
                if (backrightup2 != null && backrightup2.gridState == "red")
                {
                    diaganalBackRightLeft += 1;
                    tile backrightup3 = parentGrid.GetRelativeTile(coordinates, Vector3Int.forward * 3 + Vector3Int.right * 3 + Vector3Int.up *3);
                    if (backrightup3 != null && backrightup3.gridState == "red")
                    {
                        diaganalBackRightLeft += 1;
                    }
                }
            }
            tile backleftdown1 = parentGrid.GetRelativeTile(coordinates, Vector3Int.left + Vector3Int.down + Vector3Int.back);
            if (backleftdown1 != null && backleftdown1.gridState == "red")
            {
                diaganalBackRightLeft += 1;
                tile backleftdown2 = parentGrid.GetRelativeTile(coordinates, Vector3Int.left *2+ Vector3Int.down*2 + Vector3Int.back*2);
                if (backleftdown2 != null && backleftdown2.gridState == "red")
                {
                    diaganalBackRightLeft += 1;
                    tile backleftdown3 = parentGrid.GetRelativeTile(coordinates, Vector3Int.left *3+ Vector3Int.down*3 + Vector3Int.back*3);
                    if (backleftdown3 != null && backleftdown3.gridState == "red")
                    {
                        diaganalBackRightLeft += 1;
                    }
                }
            }
            tile Bbackrightup1 = parentGrid.GetRelativeTile(coordinates, Vector3Int.right + Vector3Int.up + Vector3Int.forward);
            if (Bbackrightup1 != null && Bbackrightup1.gridState == "blue")
            {
                BdiaganalBackRightLeft += 1;
                tile Bbackrightup2 = parentGrid.GetRelativeTile(coordinates, Vector3Int.forward * 2 + Vector3Int.right * 2 + Vector3Int.up * 2);
                if (Bbackrightup2 != null && Bbackrightup2.gridState == "blue")
                {
                    BdiaganalBackRightLeft += 1;
                    tile Bbackrightup3 = parentGrid.GetRelativeTile(coordinates, Vector3Int.forward * 3 + Vector3Int.right * 3 + Vector3Int.up * 3);
                    if (Bbackrightup3 != null && Bbackrightup3.gridState == "blue")
                    {
                        BdiaganalBackRightLeft += 1;
                    }
                }
            }
            tile Bbackleftdown1 = parentGrid.GetRelativeTile(coordinates, Vector3Int.left + Vector3Int.down + Vector3Int.back);
            if (Bbackleftdown1 != null && Bbackleftdown1.gridState == "blue")
            {
                BdiaganalBackRightLeft += 1;
                tile Bbackleftdown2 = parentGrid.GetRelativeTile(coordinates, Vector3Int.left * 2 + Vector3Int.down * 2 + Vector3Int.back * 2);
                if (Bbackleftdown2 != null && Bbackleftdown2.gridState == "blue")
                {
                    BdiaganalBackRightLeft += 1;
                    tile Bbackleftdown3 = parentGrid.GetRelativeTile(coordinates, Vector3Int.left * 3 + Vector3Int.down * 3 + Vector3Int.back * 3);
                    if (Bbackleftdown3 != null && Bbackleftdown3.gridState == "blue")
                    {
                        BdiaganalBackRightLeft += 1;
                    }
                }
            }
            //.a
            tile backLeftup1 = parentGrid.GetRelativeTile(coordinates, Vector3Int.left + Vector3Int.up + Vector3Int.forward);
            if (backLeftup1 != null && backLeftup1.gridState == "red")
            {
                diaganalBackLeftRight += 1;
                tile backLeftup2 = parentGrid.GetRelativeTile(coordinates, Vector3Int.left *2+ Vector3Int.up *2+ Vector3Int.forward*2);
                if (backLeftup2 != null && backLeftup2.gridState == "red")
                {
                    diaganalBackLeftRight += 1;
                    tile backLeftup3 = parentGrid.GetRelativeTile(coordinates, Vector3Int.left*3+ Vector3Int.up *3+ Vector3Int.forward*3);
                    if (backLeftup3 != null && backLeftup3.gridState == "red")
                    {
                        diaganalBackLeftRight += 1;
                    }
                }
            }
            tile backRightDown1 = parentGrid.GetRelativeTile(coordinates, Vector3Int.right + Vector3Int.down + Vector3Int.back);
            if (backRightDown1 != null && backRightDown1.gridState == "red")
            {
                diaganalBackLeftRight += 1;
                tile backRightDown2 = parentGrid.GetRelativeTile(coordinates, Vector3Int.right * 2 + Vector3Int.down * 2 + Vector3Int.back * 2);
                if (backRightDown2 != null && backRightDown2.gridState == "red")
                {
                    diaganalBackLeftRight += 1;
                    tile backRightDown3 = parentGrid.GetRelativeTile(coordinates, Vector3Int.right * 3 + Vector3Int.down * 3 + Vector3Int.back * 3);
                    if (backRightDown3 != null && backRightDown3.gridState == "red")
                    {
                        diaganalBackLeftRight += 1;
                    }
                }
            }
            tile BbackLeftup1 = parentGrid.GetRelativeTile(coordinates, Vector3Int.left + Vector3Int.up + Vector3Int.forward);
            if (BbackLeftup1 != null && BbackLeftup1.gridState == "blue")
            {
                BdiaganalBackLeftRight += 1;
                tile BbackLeftup2 = parentGrid.GetRelativeTile(coordinates, Vector3Int.left *2+ Vector3Int.up *2+ Vector3Int.forward*2);
                if (BbackLeftup2 != null && BbackLeftup2.gridState == "blue")
                {
                    BdiaganalBackLeftRight += 1;
                    tile BbackLeftup3 = parentGrid.GetRelativeTile(coordinates, Vector3Int.left * 3 + Vector3Int.up * 3 + Vector3Int.forward*3);
                    if (BbackLeftup3 != null && BbackLeftup3.gridState == "blue")
                    {
                        BdiaganalBackLeftRight += 1;
                    }
                }
            }
            tile BbackRightdown1 = parentGrid.GetRelativeTile(coordinates, Vector3Int.right + Vector3Int.down + Vector3Int.back);
            if (BbackRightdown1 != null && BbackRightdown1.gridState == "blue")
            {
                BdiaganalBackLeftRight += 1;
                tile BbackRightdown2 = parentGrid.GetRelativeTile(coordinates, Vector3Int.right * 2 + Vector3Int.down * 2 + Vector3Int.back * 2);
                if (BbackRightdown2 != null && BbackRightdown2.gridState == "blue")
                {
                    BdiaganalBackLeftRight += 1;
                    tile BbackRightdown3 = parentGrid.GetRelativeTile(coordinates, Vector3Int.right * 3 + Vector3Int.down * 3 + Vector3Int.back * 3);
                    if (BbackRightdown3 != null && BbackRightdown3.gridState == "blue")
                    {
                        BdiaganalBackLeftRight += 1;
                    }
                }
            }
            //vert back
            tile verticalUpBack1 = parentGrid.GetRelativeTile(coordinates, Vector3Int.up + Vector3Int.back);
            if (verticalUpBack1 != null && verticalUpBack1.gridState == "red")
            {
                vecticalBackFornt += 1;

                tile verticalUpBack2 = parentGrid.GetRelativeTile(coordinates, Vector3Int.up*2 + Vector3Int.back*2);
                if (verticalUpBack2 != null && verticalUpBack2.gridState == "red")
                {
                    vecticalBackFornt += 1;

                    tile verticalUpBack3 = parentGrid.GetRelativeTile(coordinates, Vector3Int.up * 3 + Vector3Int.back * 3);
                    if (verticalUpBack3 != null && verticalUpBack3.gridState == "red")
                    {
                        vecticalBackFornt += 1;
                    }
                }
            }
            tile verticalDownBack1 = parentGrid.GetRelativeTile(coordinates, Vector3Int.down + Vector3Int.forward);
            if (verticalDownBack1 != null && verticalDownBack1.gridState == "red")
            {
                vecticalBackFornt += 1;

                tile verticalDownBack2 = parentGrid.GetRelativeTile(coordinates, Vector3Int.down*2 + Vector3Int.forward*2);
                if (verticalDownBack2 != null && verticalDownBack2.gridState == "red")
                { 
                    vecticalBackFornt += 1;

                    tile verticalDownBack3 = parentGrid.GetRelativeTile(coordinates, Vector3Int.down*3 + Vector3Int.forward*3);
                    if (verticalDownBack3 != null && verticalDownBack3.gridState == "red")
                    {
                        vecticalBackFornt += 1;
                    }
                }
            }
            tile verticalUpback1 = parentGrid.GetRelativeTile(coordinates, Vector3Int.up + Vector3Int.forward);
            if (verticalUpback1 != null && verticalUpback1.gridState == "red")
            {
                vecticalForntBack += 1;

                tile verticalUpback2 = parentGrid.GetRelativeTile(coordinates, Vector3Int.up * 2 + Vector3Int.forward * 2);
                if (verticalUpback2 != null && verticalUpback1.gridState == "red")
                {
                    vecticalForntBack += 1;

                    tile verticalUpback3 = parentGrid.GetRelativeTile(coordinates, Vector3Int.up * 3 + Vector3Int.forward * 3);
                    if (verticalUpback3 != null && verticalUpback3.gridState == "red")
                    {
                        vecticalForntBack += 1;
                    }
                }
            }
            tile verticaldownforward1 = parentGrid.GetRelativeTile(coordinates, Vector3Int.down + Vector3Int.back);
            if (verticaldownforward1 != null && verticaldownforward1.gridState == "red")
            {
                vecticalForntBack += 1;

                tile verticaldownforward2 = parentGrid.GetRelativeTile(coordinates, Vector3Int.down * 2 + Vector3Int.back * 2);
                if (verticaldownforward2 != null && verticaldownforward2.gridState == "red")
                {
                    vecticalForntBack += 1;

                    tile verticaldownforward3 = parentGrid.GetRelativeTile(coordinates, Vector3Int.down * 3 + Vector3Int.back * 3);
                    if (verticaldownforward3 != null && verticaldownforward3.gridState == "red")
                    {
                        vecticalForntBack += 1;
                    }
                }
            }
            // blue
            tile bverticalUpBack1 = parentGrid.GetRelativeTile(coordinates, Vector3Int.up + Vector3Int.back);
            if (bverticalUpBack1 != null && bverticalUpBack1.gridState == "blue")
            {
                bvecticalBackFornt += 1;

                tile bverticalUpBack2 = parentGrid.GetRelativeTile(coordinates, Vector3Int.up * 2 + Vector3Int.back * 2);
                if (bverticalUpBack2 != null && bverticalUpBack2.gridState == "blue")
                {
                    bvecticalBackFornt += 1;

                    tile bverticalUpBack3 = parentGrid.GetRelativeTile(coordinates, Vector3Int.up * 3 + Vector3Int.back * 3);
                    if (bverticalUpBack3 != null && bverticalUpBack3.gridState == "blue")
                    {
                        bvecticalBackFornt += 1;
                    }
                }
            }
            tile bverticalDownBack1 = parentGrid.GetRelativeTile(coordinates, Vector3Int.down + Vector3Int.forward);
            if (bverticalDownBack1 != null && bverticalDownBack1.gridState == "blue")
            {
                bvecticalBackFornt += 1;

                tile bverticalDownBack2 = parentGrid.GetRelativeTile(coordinates, Vector3Int.down * 2 + Vector3Int.forward * 2);
                if (bverticalDownBack2 != null && bverticalDownBack2.gridState == "blue")
                {
                    bvecticalBackFornt += 1;

                    tile bverticalDownBack3 = parentGrid.GetRelativeTile(coordinates, Vector3Int.down * 3 + Vector3Int.forward * 3);
                    if (bverticalDownBack3 != null && bverticalDownBack3.gridState == "blue")
                    {
                        bvecticalBackFornt += 1;
                    }
                }
            }
            tile bverticalUpback1 = parentGrid.GetRelativeTile(coordinates, Vector3Int.up + Vector3Int.forward);
            if (bverticalUpback1 != null && bverticalUpback1.gridState == "blue")
            {
                bvecticalForntBack += 1;

                tile bverticalUpback2 = parentGrid.GetRelativeTile(coordinates, Vector3Int.up * 2 + Vector3Int.forward * 2);
                if (bverticalUpback2 != null && bverticalUpback1.gridState == "blue")
                {
                    bvecticalForntBack += 1;

                    tile bverticalUpback3 = parentGrid.GetRelativeTile(coordinates, Vector3Int.up * 3 + Vector3Int.forward * 3);
                    if (bverticalUpback3 != null && bverticalUpback3.gridState == "blue")
                    {
                        bvecticalForntBack += 1;
                    }
                }
            }
            tile bverticaldownforward1 = parentGrid.GetRelativeTile(coordinates, Vector3Int.down + Vector3Int.back);
            if (bverticaldownforward1 != null && bverticaldownforward1.gridState == "blue")
            {
                bvecticalForntBack += 1;

                tile bverticaldownforward2 = parentGrid.GetRelativeTile(coordinates, Vector3Int.down * 2 + Vector3Int.back * 2);
                if (bverticaldownforward2 != null && bverticaldownforward2.gridState == "blue")
                {
                    bvecticalForntBack += 1;

                    tile bverticaldownforward3 = parentGrid.GetRelativeTile(coordinates, Vector3Int.down * 3 + Vector3Int.back * 3);
                    if (bverticaldownforward3 != null && bverticaldownforward3.gridState == "blue")
                    {
                        bvecticalForntBack += 1;
                    }
                }
            }
            print(vecticalForntBack + "fort");

            if (leftRightcounter >= 4 || upDowncounter >= 4 || diaganalRightleft >= 4 || diaganalLeftRight >= 4 || forwardBackcounter >= 4 || frontleftright >= 4 || backleftright >= 4|| diaganalBackRightLeft>=4 || diaganalBackLeftRight >=4|| vecticalBackFornt >=4 || vecticalForntBack >=4 && parentGrid.GameState != "GameOver")
            {
                parentGrid.Winner.rectTransform.position = new Vector3(1.7f, 3.25f, 0);
                parentGrid.Winner.text = " <color=red> Red wins </color> <br> press 'space' to restart";
                parentGrid.GameState = "GameOver";
            }
            if (BleftRightcounter >= 4 || BupDowncounter >= 4 || BdiaganalRightleft >= 4 || BdiaganalLeftRight >= 4 || BforwardBackcounter >= 4 || Bfrontleftright >= 4 || Bbackleftright >= 4|| BdiaganalBackRightLeft >= 4 || BdiaganalBackLeftRight >= 4 || bvecticalForntBack>=4 || bvecticalBackFornt>=4 && parentGrid.GameState != "GameOver")
            {
                parentGrid.Winner.rectTransform.position = new Vector3(1.7f, 3.25f, 0);
                parentGrid.Winner.text = " <color=blue>Blue wins </color> <br> press 'space' to restart";
                parentGrid.GameState = "GameOver";
            }
        }
    }
    private void OnMouseOver()
    {
        if (parentGrid.GameState != "GameOver")
        {
            if (gridState == "white")
            {
                spriteRenderer.color = Color.gray;
            }
        }
    }
    void OnMouseExit()
    {
        if (parentGrid.GameState != "GameOver")
        {
            if (gridState == "white")
            {
                spriteRenderer.color = Color.white;
            }
        }
    }
}
