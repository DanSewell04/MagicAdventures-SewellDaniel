using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public Transform firePosition;
    public GameObject projectile;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    { 
        //get input from player 
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(projectile, firePosition.position, firePosition.rotation);
        }
        //spawn a projectile
          // Where to spawn the projectile

    }
}
