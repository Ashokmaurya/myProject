using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
   


public class ChangeBG : MonoBehaviour
{


    public Image BG;

    public List<Sprite> allBgImage = new List<Sprite>() ;

    int countValue=0;

   private void start()
    {
        countValue = 0;
        BG.sprite = allBgImage[countValue];

    }


    public void Back()
    {
        if ( countValue>0)
        {
            countValue = countValue - 1;
            Debug.Log("value" + countValue);

            BG.sprite = allBgImage[countValue];
        }
    }

    public void Next()
    {
        if(allBgImage.Count-1> countValue)
        {
            countValue = countValue + 1;
            Debug.Log("value" + countValue);

            BG.sprite = allBgImage[countValue];
        }
    }




}
