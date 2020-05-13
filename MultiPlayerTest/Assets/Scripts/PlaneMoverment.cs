using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class PlaneMoverment : NetworkBehaviour
{
    [SerializeField] private float speed;

    private void FixedUpdate()
    {
        if (this.isLocalPlayer)
        {
            float movermentX = Input.GetAxis("Horizontal");
            //float movermentY = Input.GetAxis("Vertical");
            GetComponent<Rigidbody2D>().velocity = new Vector2(movermentX * speed, 0.0f);
            //GetComponent<Rigidbody2D>().velocity = new Vector2(0.0f ,movermentY * speed);
        }
    }
}
