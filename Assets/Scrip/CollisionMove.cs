using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionMove : MonoBehaviour
{
   [SerializeField] float freezetime  = 5f;
    void OnTriggerEnter(Collider other) 
    {
      Debug.Log($"{this.name} **Trigger by **{other.gameObject.name}");  
      FreezeAction();
      
    }
    void FreezeAction()
    {
        GetComponent<PlayerControl>().enabled = false;
        Invoke("ReloadLevel", freezetime);
    }

      void ReloadLevel()

    {
      int reloadLevel = SceneManager.GetActiveScene().buildIndex;
      SceneManager.LoadScene(reloadLevel);
    }
 }
