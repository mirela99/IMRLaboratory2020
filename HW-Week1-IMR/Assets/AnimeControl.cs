using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimeControl : MonoBehaviour
{

    private Animator mAnimator;

    // Start is called before the first frame update
    void Start()
    {
        mAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        bool walking = Input.GetKey(KeyCode.W);

        mAnimator.SetBool("walking", walking);

        if(Input.GetKeyDown(KeyCode.A))
        {
            mAnimator.SetTrigger("attack");
        }
    }
}
