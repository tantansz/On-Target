using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wood2 : MonoBehaviour
{
    private int speed = 2;

    public AudioClip audioWoodColisao;

    void Start()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D> ();
        rb.velocity = new Vector2(speed, 0);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        vidaScript.instance.AddVidas();
        AudioSource.PlayClipAtPoint(audioWoodColisao, transform.position);
    }

    void onBecomeInvisible()
    {
        Destroy(gameObject);
    }
}
