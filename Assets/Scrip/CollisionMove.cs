using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionMove : MonoBehaviour
{
     void OnCollisionEnter(Collision other)
    {
        Debug.Log(this.name + "hit log" + other.gameObject.name);
    }
    void OnTriggerEnter(Collider other) {
      Debug.Log($"{this.name}**Trigger by **{other.gameObject.name}");  
    }
}
