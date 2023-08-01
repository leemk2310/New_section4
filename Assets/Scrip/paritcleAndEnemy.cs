using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paritcleAndEnemy : MonoBehaviour
{

    void OnParticleCollision(GameObject other) 
    {
        Debug.Log($"{this.name}hit on + {other.gameObject.name}");
         Destroy(gameObject);
    }
}
