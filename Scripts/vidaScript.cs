using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class vidaScript : MonoBehaviour
{
    public static vidaScript instance;

    public MenuPrincipalScript gameManager;
    
    public Text vidasUI;

    public GameObject madeiraPrefab;

    public int vidas = 0;

    public float posx = 0;

    public float posy = 0;

    void Start()
    {
        vidasUI.text = vidas.ToString() + " ";
    }

    public void Awake()
    {
        instance = this;
    }


    public void AddVidas()
    {
        vidas += 1;
        vidasUI.text = vidas.ToString() + " ";

        if(madeiraPrefab != null)
        {
            Vector3 posicao = new Vector3(posx + vidas, posy, 0);
            Instantiate(madeiraPrefab, posicao, Quaternion.identity);
        }

        if(vidas == 5)
        {
            Invoke("Action", 1.0f);
            gameManager.GameOver();
        }
    }
}
