﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public GameUI UI;
    public Button ResumeGameButton;
    public Button ExitGameButton;

    private void Awake()
    {
        ResumeGameButton?.onClick.AddListener(OnResumeGameButton);
        ExitGameButton?.onClick.AddListener(OnExitGamePressed);
    }

    private void OnExitGamePressed()
    {
        SceneManager.LoadScene("MainMenu");
    }

    private void OnResumeGameButton()
    {
        UI?.EnablePauseMenu(false);
    }
}
