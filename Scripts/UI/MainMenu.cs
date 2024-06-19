using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private CanvasGroup mainPanel;
    [SerializeField] private CanvasGroup optionPanel;

    private void Awake()
    {
        mainPanel.ShowCanvasGroup();
        optionPanel.HideCanvasGroup();
    }

    public void PlayLevel()
    {
        SceneManager.LoadScene("Level1");
    }

    public void ShowMainPanel()
    {
        mainPanel.ShowCanvasGroup();
        optionPanel.HideCanvasGroup();
    }

    public void ShowOptionPanel()
    {
        mainPanel.HideCanvasGroup();
        optionPanel.ShowCanvasGroup();
    }

    public void PlaySound()
    {
        MusicManager.Instance.PlayButtonSound();
    }

    public void ButtonSound(AudioClip clip)
    {
        MusicManager.Instance.PlaySFXSound(clip);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
