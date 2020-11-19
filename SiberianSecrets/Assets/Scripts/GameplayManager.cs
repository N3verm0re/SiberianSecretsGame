using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameplayManager : MonoBehaviour
{
    #region Singleton
    private static GameplayManager _instance;
    public static GameplayManager Instance { get { return _instance; } }
    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }

        Time.timeScale = 1;
    }
    #endregion

    public GameObject PausePanel;
    public GameObject GameHUD;
    public GameObject player;
    PlayerControls playerControls;
    public GameObject[] pauseMenuOptions;
    int pauseMenuOptionsIndex = 0;
    private void Start()
    {
        GameHUD.SetActive(true);
        PausePanel.SetActive(false);
        playerControls = player.GetComponent<PlayerController>().controls;

        //Pause Controls
        playerControls.PauseNavigation.Unpause.performed += ctx => Unpause();
        playerControls.PauseNavigation.Navigate.performed += ctx => NavigateButtonIndexes(ctx.ReadValue<Vector2>());
        playerControls.PauseNavigation.Select.performed += ctx => PerformSelect();
    }
    public void PauseGame()
    {
        GameHUD.SetActive(false);
        PausePanel.SetActive(true);

        playerControls.Gameplay.Disable();
        playerControls.PauseNavigation.Enable();

        Time.timeScale = 0f;
    }

    public void Unpause()
    {
        PausePanel.SetActive(false);
        GameHUD.SetActive(true);

        playerControls.PauseNavigation.Disable();
        playerControls.Gameplay.Enable();

        Time.timeScale = 1f;
    }

    void NavigateButtonIndexes(Vector2 nav)
    {
        if (pauseMenuOptionsIndex > 0 && nav.x < 0)
        {
            pauseMenuOptionsIndex--;
            EventSystem.current.SetSelectedGameObject(pauseMenuOptions[pauseMenuOptionsIndex]);
        }
        else if (pauseMenuOptionsIndex < pauseMenuOptions.Length - 1 && nav.x > 0)
        {
            pauseMenuOptionsIndex++;
            EventSystem.current.SetSelectedGameObject(pauseMenuOptions[pauseMenuOptionsIndex]);
        }
    }

    void PerformSelect()
    {
        Button isButton = EventSystem.current.currentSelectedGameObject.GetComponent<Button>();
        if (isButton != null)
        {
            isButton.onClick.Invoke();
        }
    }

    public void QuitToMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    private void OnDisable()
    {
        playerControls.Gameplay.Disable();
        playerControls.PauseNavigation.Disable();
    }
}
