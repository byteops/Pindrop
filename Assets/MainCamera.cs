using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MianCamera : MonoBehaviour
{
   private bool gameHasEnded=false;

   public void EndGame()
   {
       if(gameHasEnded)
            return;

            gameHasEnded=true;
            Debug.Log("END GAME");
   }
}
