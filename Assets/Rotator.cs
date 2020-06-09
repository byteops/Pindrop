using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
   public float speed;

    private Vector3 scaleChange;
   void Update()
   {
       transform.Rotate(0f, 0f,speed*Time.deltaTime);
       scaleChange = new Vector3(-0.05f, -0.05f, 0);
       if(Score.PinCount>=10){
            GameObject varGameObject = GameObject.Find("PinSpawnPoint"); 
            transform.localScale += scaleChange;
            varGameObject.GetComponent<Spawner>().enabled = false;
           changelevel();
           
       }
   }
   void changelevel(){
              
           int childs = transform.childCount;
 for (int i = childs-1; i > 0; i--)
 {
     GameObject.Destroy(transform.GetChild(i).gameObject);
 }
 GameObject.Destroy(transform.GetChild(0).gameObject);
 GameObject varGameObject = GameObject.Find("PinSpawnPoint"); 
 
            varGameObject.GetComponent<Spawner>().enabled = true;
       }  

}
