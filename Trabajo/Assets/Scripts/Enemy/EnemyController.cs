using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] protected float enemyHealth;
    [SerializeField] protected float enemySpeed;
    [SerializeField] protected float enemyArmour;


    protected EnemyController(float eHealth, float eSpeed, float eArmour)
    {

    }
}
