using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;


public class CollisionMove : MonoBehaviour
{
   [SerializeField] float freezetime  = 2f;
   [SerializeField] ParticleSystem lossee;
   
    void OnTriggerEnter(Collider other) 
    {
        
        Debug.Log($"{this.name} **Trigger by **{other.gameObject.name}");  
       FreezeAction();           
    }
    

    void FreezeAction()
    {
        
        lossee.Play();
        GetComponent<MeshRenderer>().enabled= false;
        GetComponent<PlayerControl>().enabled = false;
        GetComponent<BoxCollider>().enabled= false;
        Invoke("ReloadLevel", freezetime);
    }

      void ReloadLevel()

    {
      int reloadLevel = SceneManager.GetActiveScene().buildIndex;
      SceneManager.LoadScene(reloadLevel);
    }
 }
