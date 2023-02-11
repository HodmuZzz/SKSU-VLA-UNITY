using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    //Screen object variables
    public GameObject loginUI;
    public GameObject registerUI;
    public GameObject contentUI;
    public GameObject sideMenuUI;
    public GameObject homepageUI;
    public GameObject categoryUI;
    public GameObject accountUI;
    public GameObject scoreboardUI;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != null)
        {
            Debug.Log("Instance already exists, destroying object!");
            Destroy(this);
        }
    }

    //Functions to change the login screen UI

    public void ClearScreen() //Turn off all screens
    {
        loginUI.SetActive(false);
        registerUI.SetActive(false);
        categoryUI.SetActive(false);
        accountUI.SetActive(false);
        scoreboardUI.SetActive(false);
    }

    public void LoginScreen() //Back button
    {
        ClearScreen();
        loginUI.SetActive(true);
        contentUI.SetActive(false);
    }
    public void RegisterScreen()
    {
        ClearScreen();
        registerUI.SetActive(true);
    }

    public void Content()
    {
        ClearScreen();
        contentUI.SetActive(true);
        homepageUI.SetActive(true);
    }

    public void SideMenu()
    {
        ClearScreen();
        contentUI.SetActive(true);
    }

    public void Homepage() //Logged in
    {
        ClearScreen();
        homepageUI.SetActive(true);
    }
    public void Category()
    {
        ClearScreen();
        categoryUI.SetActive(true);
    }
    public void Account()
    {
        ClearScreen();
        accountUI.SetActive(true);
    }

    public void ScoreboardScreen() //Scoreboard button
    {
        ClearScreen();
        scoreboardUI.SetActive(true);
    }
}
