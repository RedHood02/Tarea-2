using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : ProjectileController
{
    float arrowSpeed;
    float arrowDamage;
    float arrowPierceness;

    Arrow(float aSpeed, float aDamage, Rigidbody aRB, float aPierceness) : base(aSpeed, aDamage, aRB, aPierceness)
    {
        this.arrowSpeed = aSpeed;
        this.arrowDamage = aDamage;
        this.arrowPierceness = aPierceness;
    }


    private void Start()
    {
        Physics.IgnoreLayerCollision(0, 0);
        Destroy(gameObject, 5f);
        rb.AddForce(transform.up * moveSpeed, ForceMode.Impulse);
    }

    public float GetDamage()
    {
        return this.arrowDamage;
    }

    public float GetPierceness()
    {
        return this.arrowPierceness;
    }
}
