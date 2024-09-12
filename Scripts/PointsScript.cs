using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PointsScript : MonoBehaviour
{
    public static PointsScript instance;

    public Text pontosUI;
    public Text ultimoPontosUI;
    public Text recordeUI;

    public int pontos = 0;
    public int recorde = 0;
    public int ultimosPontos = 0;

    private void Awake()
    {
        instance = this;
    }

    public void salvarPontos()
    {
        PlayerPrefs.SetInt("ultimosPontos", pontos);
    }

    void Start()
    {
        recorde = PlayerPrefs.GetInt("recorde", 0);
        pontosUI.text = pontos.ToString() + " ";
        recordeUI.text = " " + recorde.ToString();

        MostrarPontos();
    }

    public void AddPoint(int coinValor)
    {
        pontos = pontos + coinValor;
        pontosUI.text = pontos.ToString() + " ";
        if (recorde < pontos)
        PlayerPrefs.SetInt("recorde", pontos);

        salvarPontos();
    }


    public void MostrarPontos()
    {
        int ultimosPontos = PlayerPrefs.GetInt("ultimosPontos", 0);
        pontosUI.text = " " + ultimosPontos.ToString();
    }
}
