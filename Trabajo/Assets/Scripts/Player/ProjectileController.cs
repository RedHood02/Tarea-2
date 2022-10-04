using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    [SerializeField] protected float moveSpeed;
    [SerializeField] protected float damage;
    [SerializeField] protected Rigidbody rb;
    [SerializeField] protected float pierceness;

    protected ProjectileController(float pSpeed, float pDamage, Rigidbody pRB, float pPierceness)
    {

    }


}
