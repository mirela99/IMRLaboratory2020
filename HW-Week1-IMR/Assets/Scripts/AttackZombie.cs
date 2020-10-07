using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class AttackZombie : MonoBehaviour
{
    public Camera cameraAr;
    float distance;
    public Animator animZombie;

    
    
    // Start is called before the first frame update
    void Start()
    {
        animZombie = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(cameraAr.GetComponent<Transform>().position, gameObject.GetComponent<Transform>().position);

        if(distance < 300.50f)
        {
            animZombie.SetBool("Attacking", true);
            animZombie.SetBool("Skip", false);
        }
        else
        {
            animZombie.SetBool("Attacking", false);
            animZombie.SetBool("Skip", true);
        }
    }
}
