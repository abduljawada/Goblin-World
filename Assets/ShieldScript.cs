using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Projectile")
        {
            collision.transform.rotation.Set (collision.transform.rotation.x, collision.transform.rotation.y + 180, collision.transform.rotation.z, collision.transform.rotation.w);
        }
    }
}
