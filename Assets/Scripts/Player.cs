using UnityEngine;
using System.Collections;

public class Player : Character {
    private int attackCooldown = 0;
    void movePlayer()
    {
        int x = 0;
        int y = 0;
        if (Input.GetKey("w"))
        {
            y++;
        }
        if (Input.GetKey("a"))
        {
            x--;
        }
        if (Input.GetKey("s"))
        {
            y--;
        }
        if (Input.GetKey("d"))
        {
            x++;
        }
        move(x, y);
    }

    void attack()
    {
        if (Input.GetMouseButtonDown(0) && attackCooldown == 0){
            anim.Play("PlayerAttack");
            GameObject childObj = Instantiate(swingObj);
            childObj.transform.parent = this.transform;
            childObj.transform.position = transform.position + new Vector3(0.3f, 0);
            attackCooldown = 25;
        }
    }
    
    void Update()
    {
        movePlayer();
        attack();
        if (attackCooldown > 0)
        {
            attackCooldown--;
        }
        
    }
}
