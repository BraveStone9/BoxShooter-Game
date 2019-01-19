using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartGame : MonoBehaviour
{
    // respond on collisions
    void OnCollisionEnter(Collision newCollision)
    {
        // only do stuff if hit by a projectile
        if (newCollision.gameObject.tag == "Projectile")
        {
            // call the RestartGame function in the game manager
            GameManager.gm.RestartGame();
        }
    }

}
