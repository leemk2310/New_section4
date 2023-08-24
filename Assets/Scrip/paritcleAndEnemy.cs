using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class paritcleAndEnemy : MonoBehaviour
{
    [SerializeField] GameObject gameVFX;
    [SerializeField] GameObject HitVFX;
      
    [SerializeField] int countscore = 15;
    [SerializeField] int countAndKill = 2;
    GameObject parentGameObject;
    ScoreBoard scorehit;

    void Start()
    {
        scorehit = FindAnyObjectByType<ScoreBoard>();
        parentGameObject = GameObject.FindWithTag("SpamAtRuntime");
        Rigidbody rb = gameObject.AddComponent<Rigidbody>();
        rb.GetComponent<Rigidbody>().useGravity = false;

    }
    void OnParticleCollision(GameObject other)
    {
        
        
        GameObject vfx = Instantiate(HitVFX, transform.position, Quaternion.identity); // khởi tạo 1 đối tượng vfx
       vfx.transform.parent = parentGameObject.transform;  // gán đôi tượng  làm con của  thằng parent 
        
        ProcessHit();
       if(countAndKill <1)
        {
                KillEnemy();
        }

        void ProcessHit()
        {
            countAndKill = countAndKill - 1;
            Debug.Log($"Count is now :{countAndKill}");
            scorehit.IncreaseScore(countscore);
        }
        void KillEnemy()
        {
            GameObject VFX = Instantiate(gameVFX, transform.position, Quaternion.identity); // khởi tạo 1 đối tượng VFX
            VFX.transform.parent = parentGameObject.transform;  // gán đôi tượng  làm con của  thằng parent 
            Destroy(gameObject);
        }
    }
}