using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    //Movement
    [SerializeField] float playerSpeed = 6f;

    //Combat
    [SerializeField] GameObject weaponTip;
    [SerializeField] GameObject projectilePrefab;
    [SerializeField] float timeToShoot = 4f;



    private void Update()
    {
        Movement();
        MouseController();
    }


    void Movement()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        transform.position += transform.forward * y * playerSpeed * Time.fixedDeltaTime;
        transform.position += transform.right * x * playerSpeed * Time.fixedDeltaTime;
    }


    void MouseController()
    {
        Shooting();

    }

    void Shooting()
    {
        timeToShoot -= Time.deltaTime;
        if(Input.GetMouseButton(0) && timeToShoot <= 0)
        {
            Instantiate(projectilePrefab, weaponTip.transform.position, weaponTip.transform.rotation);
            timeToShoot = 4f;
        }
    }
}
