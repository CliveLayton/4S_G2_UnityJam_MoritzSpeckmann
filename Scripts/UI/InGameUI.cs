using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InGameUI : MonoBehaviour
{
   [SerializeField] private CanvasGroup looseScreen;
   [SerializeField] private CanvasGroup winScreen;


   private void Awake()
   {
      looseScreen.HideCanvasGroup();
      winScreen.HideCanvasGroup();
      Time.timeScale = 1f;
   }

   public void ShowLooseScreen()
   {
      looseScreen.ShowCanvasGroup();
      Time.timeScale = 0f;
   }

   public void ShowWinScreen()
   {
      winScreen.ShowCanvasGroup();
      Time.timeScale = 0f;
   }

   public void LoadMainMenu()
   {
      SceneManager.LoadScene("MainMenu");
   }

   public void ReloadScene()
   {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
   }
}
