using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimator : MonoBehaviour
{

    //enemyanimator
    private Animator anim;

    void Awake()
    {
        anim = GetComponent<Animator>();
    }




    public void Walk(bool walk)
    {

        anim.SetBool("Walk", walk);
    }



    public void Run(bool run)
    {
        anim.SetBool("Run", run);
    }



    public void Attack()
    {
        anim.SetTrigger("Attack");
    }


    /*
    public void Dead()
    {
        anim.SetTrigger(AnimationTags.DEAD_TRIGGER);
    }
    */

}
