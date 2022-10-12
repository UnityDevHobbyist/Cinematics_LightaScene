using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunReverse : MonoBehaviour
{
    private Animator mAnimator;

    // Start is called before the first frame update
    void Start()
    {
        mAnimator = GetComponent<Animator>();
        mAnimator.SetTrigger("TrRun");
    }

    // Update is called once per frame
    void Update()
    {
        if(mAnimator != null)
        {

        }
    }
}
