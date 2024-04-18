using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
   void OnCollisionEnter(Collision col)
   {
    if (col.gameObject.CompareTag("Box"))
    {
        Destroy(col.gameObject);
        Destroy(this.gameObject);
    }
   }
}

