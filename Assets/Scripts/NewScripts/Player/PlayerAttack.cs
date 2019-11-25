using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class  PlayerAttack : MonoBehaviour
{

    private WeaponManager weapon_Manager;
    public static string shoot; 

    public float fireRate = 15f;
    public float damage = 20f;

    private Animator zoomCameraAnim;
    private bool zoomed;
    private Camera mainCam;



    private bool is_Aiming;

    [SerializeField]
    private GameObject arrow_Prefab;

    [SerializeField]
    private Transform bowStart;

    void Awake()
    {

        weapon_Manager = GetComponent<WeaponManager>();
        //find camera child
    //zoomCameraAnim = transform.Find("LookRoot").transform.Find("Fp Camera").GetComponent<Animator>();



        mainCam = Camera.main;

    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        WeaponShoot();
    }

    void WeaponShoot()
    {
            if (Input.GetMouseButtonDown(0) || shoot == "shoot")
            {

            while(shoot == "shoot")
            {
                shoot = "";
            }




            weapon_Manager.GetCurrentSelectedWeapon().ShootAnimation();

            is_Aiming = true;

            if (weapon_Manager.GetCurrentSelectedWeapon().bulletType== WeaponBulletType.ARROW)
                        {

                            // throw arrow
                            ArrowFire(true);
            }

             }

    }

   
  

    //FIRES arrow in the directoin of the camera
    void ArrowFire(bool throwArrow)
    {

        if (throwArrow)
        {

      

        }
     

    }
   

}
