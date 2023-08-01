using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionMove : MonoBehaviour
{
     void OnTriggerEnter(Collider other) 
    {
      Debug.Log($"{this.name}**Trigger by **{other.gameObject.name}");  
      int reloadLevel = SceneManager.GetActiveScene().buildIndex;
      SceneManager.LoadScene(reloadLevel);

    }
}
