using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuPrincipalScript : MonoBehaviour
{
[SerializeField]private string nomeDoLevelDeJogo;
[SerializeField]private GameObject painelMenuInicial;
[SerializeField]private GameObject painelCreditos;
[SerializeField]private GameObject painelThank;


  public void Jogar()
  {
    SceneManager.LoadScene(nomeDoLevelDeJogo);  
  }
  
  public void AbrirCreditos()
  {
    painelMenuInicial.SetActive(false);
    painelCreditos.SetActive(true);
  }  

  public void AbrirThank()
  {
    painelCreditos.SetActive(false);
    painelThank.SetActive(true);
  }  

  public void FecharThank()
  {
    painelThank.SetActive(false);
    painelMenuInicial.SetActive(true);
  }  
  public void FecharCreditos()
  {
    painelCreditos.SetActive(false);
    painelMenuInicial.SetActive(true);
  }

  public void SairJogo()
  {
    Debug.Log("Sair do Jogo");
    Application.Quit();
  }

  public void GameOver()
  {
    SceneManager.LoadScene("GameOver");
  }
  
  public void Fim()
  {
    SceneManager.LoadScene("Fim");
  }

  
  public float TimeLeft;
  public bool TimerOn = false;

  public Text TimerTxt;

  void Start()
  {
    TimerOn = true;
  }

  void Update()
  {
    if(TimerOn)
    {
      if(TimeLeft > 0)
      {
        TimeLeft -= Time.deltaTime;
        updateTimer(TimeLeft);
      }
      else
      {
        Debug.Log("tempo acabou!");
        TimeLeft = 0;
        TimerOn = false;
        Fim();
      }
    }
  }

  void updateTimer(float currentTime)
  {
    currentTime += 1;

    float minutes = Mathf.FloorToInt(currentTime / 60);
    float seconds = Mathf.FloorToInt(currentTime % 60);

    TimerTxt.text = string.Format("{0:00} : {1:00}", minutes, seconds);
  }

}

