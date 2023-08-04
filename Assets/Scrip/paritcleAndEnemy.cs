using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paritcleAndEnemy : MonoBehaviour
{
    [SerializeField] GameObject gameVFX;

    [SerializeField] Transform parent;
  
    [SerializeField] int countScore = 15;

    ScoreHit scoreBoard;
    void Start()
    {
        scoreBoard = FindAnyObjectByType<ScoreHit>();

    }

    void OnParticleCollision(GameObject other) 
    {
              
        scoreBoard.IncreaseScore(countScore);
        
      //  Debug.Log($"{this.name}hit on + {other.gameObject.name}");

        GameObject VFX = Instantiate(gameVFX, transform.position, Quaternion.identity); // khởi tạo 1 đối tượng VFX
        VFX.transform.parent = parent;  // gán đôi tượng  làm con của  thằng parent 
                 Destroy(gameObject);     
    }
}
