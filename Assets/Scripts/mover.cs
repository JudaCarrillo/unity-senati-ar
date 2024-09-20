using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour
{
    public float speed=5.0f;
    public float rotacion=50f;
    void Update()
    {
        //Movimienros de manera Horizontal y Vertical
       float m_horizontal=Input.GetAxis("Horizontal");
       float m_vertical=Input.GetAxis("Vertical");

        // Movimiento por vector
       Vector3 movimiento=new Vector3(m_horizontal,0, m_vertical);
       movimiento.Normalize();

       transform.position = transform.position + movimiento * speed * Time.deltaTime; 

       transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(movimiento), rotacion * Time.deltaTime); 

    }
}