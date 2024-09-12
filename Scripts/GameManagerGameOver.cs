using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManagerGameOver : MonoBehaviour
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

}
