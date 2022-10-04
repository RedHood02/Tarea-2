using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footman : EnemyController
{
    float footmanHealth;
    float footmanSpeed;
    float footmanArmour;


    Footman(float fHealth, float fSpeed, float fArmour) : base(fHealth, fSpeed, fArmour)
    {
        this.footmanHealth = fHealth;
        this.footmanSpeed = fSpeed;
        this.footmanArmour = fArmour;
    }


    private void Update()
    {
        
    }

    public void SetHealth(float damage, float pierceness)
    {
        if(footmanArmour > pierceness)
        {
            float realDamage = damage - footmanArmour;
            footmanHealth -= realDamage;
        }
        else
        {
            footmanHealth -= damage;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Arrow"))
        {
            Arrow a = collision.gameObject.GetComponent<Arrow>();
            SetHealth(a.GetDamage(), a.GetPierceness());
        }
    }




}
