using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paritcleAndEnemy : MonoBehaviour
{
    [SerializeField] GameObject gameVFX;
    [SerializeField] GameObject HitVFX;

    [SerializeField] Transform parent;
  
    [SerializeField] int countScore = 15;
    [SerializeField] int hitCountandKill = 5;

    ScoreHit scoreBoard;
    void Start()
    {
        scoreBoard = FindAnyObjectByType<ScoreHit>();

    }

    void OnParticleCollision(GameObject other)
    {
        ProcessHit();
        if (hitCountandKill < 1)
        {
            KillEnemy();
        }
    }

     void KillEnemy()
    {
        GameObject VFX = Instantiate(gameVFX, transform.position, Quaternion.identity); // khởi tạo 1 đối tượng VFX
        VFX.transform.parent = parent;  // gán đôi tượng  làm con của  thằng parent 
        Destroy(gameObject);
    }

    void ProcessHit()
    {
        GameObject VFX = Instantiate(HitVFX, transform.position, Quaternion.identity); // khởi tạo 1 đối tượng VFX
        VFX.transform.parent = parent;  // gán đôi tượng  làm con của  thằng parent 
        hitCountandKill = hitCountandKill - 1;

        scoreBoard.IncreaseScore(countScore);
        //  Debug.Log($"{this.name}hit on + {other.gameObject.name}");
    }
}
