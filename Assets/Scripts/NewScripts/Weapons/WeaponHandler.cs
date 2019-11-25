using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//how we are aiming
public enum WeaponAim
{
    NONE,
    SELF_AIM
}

//fire type
public enum WeaponFireType
{
    SINGLE
}


//ammo type
public enum WeaponBulletType
{
    ARROW,
    NONE
}


//this script is for managing the type of weapons and handeling their properties

public class WeaponHandler : MonoBehaviour
{

    private Animator anim;

    public WeaponAim weapon_Aim;




    [SerializeField]
    private AudioSource shootSound;

    public WeaponFireType fireType;

    public WeaponBulletType bulletType;



    //check if axe has collided with anything
    public GameObject attack_Point;

    void Awake()
    {
        anim = GetComponent<Animator>();
    }

    //shooting animation
    public void ShootAnimation()
    {
        anim.SetTrigger("Shoot");
    }
  //aiming aniamtion
            public void Aim(bool canAim)
            {
                anim.SetBool("Aim", canAim);
            }
    void Turn_On_AttackPoint()
    {
        attack_Point.SetActive(true);
    }

    void Turn_Off_AttackPoint()
    {
        if (attack_Point.activeInHierarchy)
        {
            attack_Point.SetActive(false);
        }
    }


    //playing shootsound
    // void Play_ShootSound()
    // {
    //    shootSound.Play();
    // }

    //turn on and off for axe animations

}
