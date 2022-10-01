using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrismController : MonoBehaviour
{
    private float rotateAngle = -45f;
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other);
       
        if (other.gameObject.tag == "LightPoint")
        {
            Debug.Log("Entrou");
        }
    }
    private void OnMouseDown()
    {
       RotatePrism();
    }
    private void RotatePrism()
    {
        Debug.Log("Clicou");
        rotateAngle += -45f;
        transform.Rotate(0.0f, 0.0f, rotateAngle, Space.World);
    }

}
