using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;
using UnityEngine.UI;

public class mainMenuController : MonoBehaviour
{
    public bool isPaused = false;
    public Sprite OffSprite;
    public Sprite OnSprite;
    public Sprite OffMusicSprite;
    public Sprite OnMusicSprite;
    public Button but;
    public Button Musicbut;
    public GameObject touchController;
    public GameObject mainMenuButton;

    public AudioSource mainGameAudioSource;
    public bool isPausedSong;

    public void StartGame(){
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        SceneManager.LoadScene("StartScene");
    }

    public void GoToMainMenu(){
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Time.timeScale =1;
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitGame(){
        Debug.Log("Exit");
        Application.Quit();
    }

    public void PauseGame(){
        Debug.Log("Pause");
        if(isPaused){
            if (but.image.sprite == OnSprite){
                Time.timeScale =1;
                isPaused = false;
                but.image.sprite = OffSprite;
                touchController.SetActive(true);
                mainMenuButton.SetActive(false);
            }
        }
        else{
            Time.timeScale =0;
            isPaused = true;
            but.image.sprite = OnSprite;
            touchController.SetActive(false);
            mainMenuButton.SetActive(true);
        }
    }

    public void PauseMusic(){
        if(!isPausedSong){
                Debug.Log("Music");
            if (Musicbut.image.sprite == OnMusicSprite){
                isPausedSong = true;
                mainGameAudioSource.Pause();
                Musicbut.image.sprite = OffMusicSprite;
            }
        }
        else{
            Debug.Log("NoMusic");
            isPausedSong = false;
            mainGameAudioSource.UnPause();
            Musicbut.image.sprite = OnMusicSprite;
        }
    }
}
