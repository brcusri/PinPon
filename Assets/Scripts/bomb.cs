using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bomb : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Ball"))
        {
            Destroy(gameObject);
        }
        else
        {
            Destroy(gameObject, 2f);
        }
        
    }
  



}
