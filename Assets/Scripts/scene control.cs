using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scenecontrol : MonoBehaviour
{
    public GameObject jolt, zill;

    public bool currentJolt;
    public bool currentZill;

    public static scenecontrol instance;

   

    void Awake(){
        instance = this;    
    }
        void Start(){
    }

     public void Jolt(){
        if (currentJolt == true) {
        jolt.SetActive(true);
        currentJolt = false;
        }
        if (currentJolt == false) {
        jolt.SetActive(false);
        currentJolt = true;
        }
    }
     
        public void Zill(){
        if (currentZill == true) {
        zill.SetActive(true);
        currentZill = false;
        }
        if (currentZill == false) {
        zill.SetActive(false);
        currentZill = true;
        }
     }


    /*public void switchPet(){
        if (currentPet == true)
    {
        jolt.SetActive(true);
        zill.SetActive(false);
        jolt.transform.position = zill.transform.position;
        currentPet = false;

    }
        if (currentPet == false)
    {
        jolt.SetActive(false);
        zill.SetActive(true);
        zill.transform.position = jolt.transform.position;
        currentPet = true;

    }
    }*/

    //public void hide(){
        //zill.SetActive(false);
    
}
