using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem.Controls;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    PlayerControls controls;

    GameObject currentActivePanel;
    public GameObject menuPanel, settingsPanel, tutorialPanel;
    public GameObject menuFirstButton, settingsFirstButton, tutorialFirstButton;
    Button[] menuButtonList, settingsButtonList, tutorialButtonList;
    int menuButtonIndex = 0, settingsButtonIndex = 0, tutorialButtonIndex = 0;

    private void Awake()
    {
        currentActivePanel = menuPanel;
        menuPanel.SetActive(true);
        settingsPanel.SetActive(false);
        tutorialPanel.SetActive(false);

        controls = new PlayerControls();
        //Maybe put these lists as individual scripts on each panel? Easier to use and can manually add each option to avoid navigation bugs
        menuButtonList = menuPanel.GetComponentsInChildren<Button>();
        settingsButtonList = settingsPanel.GetComponentsInChildren<Button>();
        tutorialButtonList = tutorialPanel.GetComponentsInChildren<Button>();

        //NavigationInput
        controls.MenuNavigation.Navigate.performed += ctx => navigateButtonIndexes(ctx.ReadValue<Vector2>());
        controls.MenuNavigation.ManipulateValue.performed += ctx => SliderValue(ctx.ReadValue<float>());
        controls.MenuNavigation.Select.performed += ctx => PressButton();
        controls.MenuNavigation.Cancel.performed += ctx => GoBack();
    }

    private void Update()
    {
        
    }

    public void navigateButtonIndexes(Vector2 navigation)
    {
        Debug.Log($"DpadInput: {navigation.x}, {navigation.y}");

        if (currentActivePanel == menuPanel)
        {
            if(menuButtonIndex < menuButtonList.Length - 1 && navigation.x > 0)
            {
                menuButtonIndex++;
            }
            else if (menuButtonIndex > 0 && navigation.x < 0)
            {
                menuButtonIndex--;
            }

            EventSystem.current.SetSelectedGameObject(menuButtonList[menuButtonIndex].gameObject);
        }
        else if (currentActivePanel == settingsPanel)
        {
            if (settingsButtonIndex < settingsButtonList.Length - 1 && navigation.x > 0)
            {
                settingsButtonIndex++;
            }
            else if (settingsButtonIndex > 0 && navigation.x < 0)
            {
                settingsButtonIndex--;
            }

            EventSystem.current.SetSelectedGameObject(settingsButtonList[settingsButtonIndex].gameObject);
        }
        else if (currentActivePanel == tutorialPanel)
        {
            if (tutorialButtonIndex < tutorialButtonList.Length - 1 && navigation.x > 0)
            {
                tutorialButtonIndex++;
            }
            else if (tutorialButtonIndex > 0 && navigation.x < 0)
            {
                tutorialButtonIndex = 0;
            }

            EventSystem.current.SetSelectedGameObject(tutorialButtonList[tutorialButtonIndex].gameObject);
        }
    }

    public void SliderValue(float increase)
    {
        Debug.Log($"Current Slider input is {increase}");
    }

    public void PressButton()
    {
        Button currentButton = EventSystem.current.currentSelectedGameObject.GetComponent<Button>();
        currentButton.onClick.Invoke();
    }

    public void GoBack()
    {
        //Button backButton = 
        currentActivePanel = menuPanel;
        menuPanel.SetActive(true);
        settingsPanel.SetActive(false);
        tutorialPanel.SetActive(false);
    }

    private void OnEnable()
    {
        controls.MenuNavigation.Enable();
    }

    private void OnDisable()
    {
        controls.MenuNavigation.Disable();
    }

    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void CloseGame()
    {
        Application.Quit();
    }
}
