using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollapseEnemy : MonoBehaviour
{
    [SerializeField] float timeDestroy = 2f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, timeDestroy);
    }

}
