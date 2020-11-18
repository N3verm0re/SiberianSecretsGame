using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem.Controls;
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
        controls.MenuNavigation.Select.performed += ctx => PressButton();
    }

    private void Update()
    {
        
    }

    public void navigateButtonIndexes(Vector2 navigation)
    {
        Debug.Log($"DpadInput: {navigation.x}, {navigation.y}");

        if (currentActivePanel == menuPanel)
        {
            if(menuButtonIndex < menuButtonList.Length && navigation.x > 0)
            {
                menuButtonIndex++;
            }
            else if (menuButtonIndex > 0 && navigation.y > 0)
            {
                menuButtonIndex--;
            }

            EventSystem.current.SetSelectedGameObject(menuButtonList[menuButtonIndex].gameObject);
        }
        else if (currentActivePanel == settingsPanel)
        {
            if (settingsButtonIndex < settingsButtonList.Length && navigation.x > 0)
            {
                settingsButtonIndex++;
            }
            else if (settingsButtonIndex > 0 && navigation.y > 0)
            {
                settingsButtonIndex--;
            }

            EventSystem.current.SetSelectedGameObject(settingsButtonList[settingsButtonIndex].gameObject);
        }
        else if (currentActivePanel == tutorialPanel)
        {
            if (tutorialButtonIndex < tutorialButtonList.Length && navigation.x > 0)
            {
                tutorialButtonIndex++;
            }
            else if (tutorialButtonIndex > 0 && navigation.y > 0)
            {
                tutorialButtonIndex = 0;
            }

            EventSystem.current.SetSelectedGameObject(tutorialButtonList[tutorialButtonIndex].gameObject);
        }
    }

    public void PressButton()
    {
        Button currentButton = EventSystem.current.currentSelectedGameObject.GetComponent<Button>();
        currentButton.onClick.Invoke();
    }
}
