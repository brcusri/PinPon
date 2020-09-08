using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ball : MonoBehaviour
{
    Rigidbody2D rb;
    public float ilkhiz = 8;
    public player oyuncu;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("HareketEt", 2);
    }

    private void HareketEt()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(ilkhiz, 0);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GetComponent<AudioSource>().Play();
        if(collision.gameObject.tag.Equals("bomba"))
        {
            oyuncu.SkorYap();
        }
    }
    
}
