using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitch : ScriptableObject
{
    // Start is called before the first frame update
    void Start()
    {

    }

    public enum Weapons
    {
        Pistol,
        Shotgun,
        HuntingRifle,
        AssaultRifle,
        Riveter,
        Mortar,
    }

    public Weapons currentWeapon;

    public void RunCurrentWeapon()
    {
        switch (currentWeapon)
        {
            case Weapons.Pistol:
                break;
            //function
            case Weapons.Shotgun:
                break;
            case Weapons.HuntingRifle:
                break;
            case Weapons.AssaultRifle:
                break;
            case Weapons.Riveter:
                break;
            case Weapons.Mortar:
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

}