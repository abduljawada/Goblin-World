using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] float boundXLeft;
    [SerializeField] float boundXRight;
    [SerializeField] float boundYLeft;
    [SerializeField] float boundYRight;
    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y, -10f);
        if (transform.position.x < boundXLeft)
        {
            transform.position = new Vector3(boundXLeft, transform.position.y, -10f);
        }
        if (transform.position.x > boundXRight)
        {
            transform.position = new Vector3(boundXRight, transform.position.y, -10f);
        }
        if (transform.position.y > boundYRight)
        {
            transform.position = new Vector3(transform.position.x, boundYRight, -10f);
        }
        if (transform.position.y < boundYLeft)
        {
            transform.position = new Vector3(transform.position.x, boundYLeft, -10f);
        }
    }
}
