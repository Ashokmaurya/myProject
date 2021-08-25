using System.Collections;
using UnityEngine;
using UnityEngine.UI;


public class Dice : MonoBehaviour
{

    private Sprite[] diceSides;
    private Image rend;
    public static int whosTurn = 1;
    private bool coroutineAllowed = true;
    public GameControl gameControl;

    // Use this for initialization
    private void Start()
    {
        whosTurn = 1;
        rend = GetComponent<Image>();
        diceSides = Resources.LoadAll<Sprite>("DiceSides/");
        rend.sprite = diceSides[5];
    }

    public void RoollDie()
    {
        if (!gameControl.gameOver && coroutineAllowed)
            StartCoroutine("RollTheDice");
           // GetComponent<AudioSource>().Play();
    }

    private IEnumerator RollTheDice()
    {
        coroutineAllowed = false;
        int randomDiceSide = 0;
        for (int i = 0; i <= 20; i++)
        {
            randomDiceSide = Random.Range(0, 6);
            rend.sprite = diceSides[randomDiceSide];
            yield return new WaitForSeconds(0.01f);
        }

        gameControl.diceSideThrown = randomDiceSide + 1;
        //randomDiceSide = 5;

        //SWITCH
        switch (gameControl.nofPlayers)
        {
            case 1:
                whosTurn =1;
                gameControl.MovePlayer(1);
                break;
            case 2:
                if (randomDiceSide == 5)
                {
                    if (whosTurn == 1)
                    {
                        whosTurn = 1;
                        gameControl.MovePlayer(1);
                    }
                    else if (whosTurn == 2)
                    {
                        whosTurn = 2;
                        gameControl.MovePlayer(2);
                    }
                    coroutineAllowed = true;
                }
                else
                {
                    if (whosTurn == 1)
                    {
                        whosTurn = 2;
                        gameControl.MovePlayer(1);

                    }
                    else if (whosTurn == 2)
                    {
                        whosTurn = 1;
                        gameControl.MovePlayer(2);

                    }
                }
                break;
            case 3:
                if (randomDiceSide == 5)
                {
                    if (whosTurn == 1)
                    {
                        whosTurn = 1;
                        gameControl.MovePlayer(1);
                    }
                    else if (whosTurn == 2)
                    {
                        whosTurn = 2;
                        gameControl.MovePlayer(2);
                    }else if(whosTurn == 3){
                        whosTurn =3;
                        gameControl.MovePlayer(3);
                    }
                    coroutineAllowed = true;
                }
                else
                {
                    if (whosTurn == 1)
                    {
                        whosTurn = 2;
                        gameControl.MovePlayer(1);

                    }
                    else if (whosTurn == 2)
                    {
                        whosTurn = 3;
                        gameControl.MovePlayer(2);
                    }
                    else if(whosTurn == 3){
                        whosTurn = 1;
                        gameControl.MovePlayer(3);
                    }
                }
                break;
            case 4:
                if (randomDiceSide == 5)
                {
                    if (whosTurn == 1)
                    {
                        whosTurn = 1;
                        gameControl.MovePlayer(1);
                    }
                    else if (whosTurn == 2)
                    {
                        whosTurn = 2;
                        gameControl.MovePlayer(2);
                    }else if(whosTurn == 3){
                        whosTurn =3;
                        gameControl.MovePlayer(3);
                    }
                    else if(whosTurn == 4){
                        whosTurn = 4;
                        gameControl.MovePlayer(4);
                    }
                    coroutineAllowed = true;
                }
                else
                {
                    if (whosTurn == 1)
                    {
                        whosTurn = 2;
                        gameControl.MovePlayer(1);

                    }
                    else if (whosTurn == 2)
                    {
                        whosTurn = 3;
                        gameControl.MovePlayer(2);
                    }
                    else if(whosTurn == 3){
                        whosTurn = 4;
                        gameControl.MovePlayer(3);
                    }else if(whosTurn == 4){
                        whosTurn = 1;
                        gameControl.MovePlayer(4);
                    }
                }
                break;
            

        }
        //END SWITCH

        /*  if (randomDiceSide == 5)
         {
             if (whosTurn == 1)
             {
                 whosTurn = 1;
                 gameControl.MovePlayer(1);
             }
             else if (whosTurn == 2)
             {
                 whosTurn = 2;
                 gameControl.MovePlayer(2);
             }
             coroutineAllowed = true;
         }
         else
         {
             if (whosTurn == 1)
             {
                 whosTurn = 2;
                 gameControl.MovePlayer(1);

             }
             else if (whosTurn == 2)
             {
                 whosTurn = 1;
                 gameControl.MovePlayer(2);

             }
         } */

        //
        //if 6 on the Dice
        /*         if (randomDiceSide == 5)
                {
                    for (int i = 1; i < 2; i++)
                    {
                        if (whosTurn == i)
                        {
                            gameControl.MovePlayer(i);
                            whosTurn = i;
                        }
                        else if (whosTurn == gameControl.nofPlayers)
                        {
                            gameControl.MovePlayer(gameControl.nofPlayers);
                            whosTurn = gameControl.nofPlayers;
                        }
                    }
                }
                else{
                //if 1 to 5 on Dice

                for (int i = 1; i < 2; i++)
                {
                    if (whosTurn == gameControl.nofPlayers)
                    {
                        gameControl.MovePlayer(gameControl.nofPlayers);
                        whosTurn = 1;
                        Debug.Log("this happens");
                    } 
                    else if (whosTurn == i)
                    {
                        Debug.Log("is this?");
                        gameControl.MovePlayer(i);
                        whosTurn = i + 1;
                    }
                }
                } */

        //Debug.Log(whosTurn);
        coroutineAllowed = true;

    }
}
