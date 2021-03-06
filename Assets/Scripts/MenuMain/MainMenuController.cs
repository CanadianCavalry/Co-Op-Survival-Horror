﻿using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{
    [SerializeField]
    private GameObject mainMenuPanel;
    [SerializeField]
    private GameObject hostGamePanel;
    [SerializeField]
    private GameObject joinGamePanel;
    [SerializeField]
    private GameObject characterPanel;

    // Start is called before the first frame update
    void Start()
    {
        Armory.loadGear();
        CharacterManager.loadAllCharacters();
        CharacterManager.loadCurrentCharacterFromPrefs();
        showMainMenu();
    }

    public void showMainMenu() {
        mainMenuPanel.SetActive(true);
    }

    public void hideMainMenu() {
        mainMenuPanel.SetActive(false);
    }

    public void showHostMenu() {
        hostGamePanel.SetActive(true);
    }

    public void hideHostMenu() {
        hostGamePanel.SetActive(false);
    }

    public void showJoinMenu() {
        joinGamePanel.SetActive(true);
    }

    public void hideJoinMenu() {
        joinGamePanel.SetActive(false);
    }

    public void showCharacterMenu() {
        characterPanel.SetActive(true);
    }

    public void hideCharacterMenu() {
        characterPanel.SetActive(false);
    }

    public void quitGame() {
        Debug.Log("Exiting game...");
        Application.Quit();
    }
}
