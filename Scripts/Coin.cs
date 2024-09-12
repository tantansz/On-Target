using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int valor = 10;

    public AudioClip audioCoinColisao;

    void OnCollisionEnter2D(Collision2D collision)
    {
        PointsScript.instance.AddPoint(valor);
        AudioSource.PlayClipAtPoint(audioCoinColisao, transform.position);
    }
    void OnBecameVisible()
    {
        Destroy(gameObject, 2f);
    }

    public void swapSprite(Sprite newSprite)
    {
    SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
    spriteRenderer.sprite = newSprite;
    }
}
