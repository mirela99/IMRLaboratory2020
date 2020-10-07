using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraBehaviour : MonoBehaviour
{
    public GameObject object1;
    public GameObject object2;
    public Animator skeleton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(object1.transform.position, object2.transform.position);

        if (distance <= 1)
        {
            skeleton.SetBool("camera_close", true);
        }
        else
        {
            skeleton.SetBool("camera_close", false);
        }
    }
}
