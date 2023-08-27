using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class HandMovement : MonoBehaviour
{
    private float animatorTurnAngle;
    private Animator mAnimator;

    private float dpadX;
    // Start is called before the first frame update
    void Start()
    {
        mAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //dpadX = Input.GetAxis("DpadX");

        if (mAnimator != null)
        {
            if (Input.GetKey(KeyCode.A))
            {
                //"TurnAngle" in player Animator(Perrinn 424 Nordschleife-Driving)
                animatorTurnAngle = Mathf.Lerp(animatorTurnAngle, -1, 10*Time.deltaTime);//the larger the last number the faster
                mAnimator.SetFloat("TurnAngle", animatorTurnAngle);
            } else if (Input.GetKey(KeyCode.D)) {
                //"TurnAngle" in player Animator(Perrinn 424 Nordschleife-Driving)
                //mAnimator.SetFloat("TurnAngle", 1);
                animatorTurnAngle = Mathf.Lerp(animatorTurnAngle, 1, 10*Time.deltaTime);
                mAnimator.SetFloat("TurnAngle", animatorTurnAngle);
            } else {
                animatorTurnAngle = Mathf.Lerp(animatorTurnAngle, 0, 10*Time.deltaTime);
                mAnimator.SetFloat("TurnAngle", animatorTurnAngle);
            }
        }
    }
}
