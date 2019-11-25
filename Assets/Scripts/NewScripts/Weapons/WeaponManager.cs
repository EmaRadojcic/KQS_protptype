using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    //array for how many weapons you want to add
    [SerializeField]
    private WeaponHandler[] weapons;


    //gets what weapon u are currently on 
    private int current_Weapon_Index;
    void Start()
    {
        current_Weapon_Index = 0;
        //set acitve first game  object
        weapons[current_Weapon_Index].gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

        //press 1 for axe
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            TurnOnSelectedWeapon(0);
        }
        //press 2 for bow
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            TurnOnSelectedWeapon(1);
        }

    } 



    //whatever weapon is select it acitvates and it de acticates the others so 
    //you you are not seeing double weapons
    void TurnOnSelectedWeapon(int weaponIndex)
    {

        if (current_Weapon_Index == weaponIndex)
            return;

        // turn off weapon
        weapons[current_Weapon_Index].gameObject.SetActive(false);

        // turn on the weapon
        weapons[weaponIndex].gameObject.SetActive(true);

        // gets o
        current_Weapon_Index = weaponIndex;

    }

    public WeaponHandler GetCurrentSelectedWeapon()
    {
        return weapons[current_Weapon_Index];
    }
}
