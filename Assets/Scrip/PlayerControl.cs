using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class PlayerControl : MonoBehaviour
{

    [SerializeField] float Movespeed = 5f;
    [SerializeField] float Xrank = 10f;
    [SerializeField] float Yrank = 10f;
    [SerializeField] float Pitchfactor = -2f;
    [SerializeField] float PitchControl = 5f;
    [SerializeField] float Yawfactor = -2f;
    [SerializeField] float RollControl = 5f;
    [SerializeField] GameObject[] ArrayAmmo;
    // Update is called once per frame
    float HorizontalThrow;
    float Verticalthrow;
    void Update()
    {
        tranformlocation();
        tranformRotation();
        ProcessFiring();
    }

    void tranformRotation()
    {
        float Pitch = transform.localPosition.y * Pitchfactor + Verticalthrow * PitchControl;
        float Yaw = transform.localPosition.x * Yawfactor;
        float Roll = HorizontalThrow * RollControl;
        transform.localRotation = Quaternion.Euler(Pitch, Yaw, Roll);

    }
    void tranformlocation()
    {
        HorizontalThrow = Input.GetAxis("Horizontal");
        Verticalthrow = Input.GetAxis("Vertical");

        float Xput = HorizontalThrow * Time.deltaTime * Movespeed; // thuc hien 1 action move

        float Xnewpost = transform.localPosition.x + Xput; // check vi tri hien tai va move toi vi tri  khi thuc hien action

        float XnewpostRank = Mathf.Clamp(Xnewpost, -Xrank, Xrank);  //set rank khi move

        float Yput = Verticalthrow * Time.deltaTime * Movespeed;
        float Ynewpost = transform.localPosition.y + Yput;
        float YnewpostRank = Mathf.Clamp(Ynewpost, -Yrank, Yrank);


        transform.localPosition = new Vector3(XnewpostRank, YnewpostRank, transform.localPosition.z);
    }
    void ProcessFiring()
    {
        if (Input.GetButton("Fire1"))
        {
            ActiveLaser(true);
        }
        else
        {
            ActiveLaser(false);
        }

    }

    void ActiveLaser(bool isActive)
    {
        foreach (GameObject laser in ArrayAmmo)
        {
            var emissionModule = laser.GetComponent<ParticleSystem>().emission;
            emissionModule.enabled = isActive;
        }
    }
}