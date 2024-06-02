using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private Animator animatorLattice;
    [SerializeField] private Animator animatorScreen;
    private AudioManager audioManager;

    private void Start()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    public void PlayGame()
    {
        animatorLattice.SetBool("IsStartGame", true);
        StartCoroutine(WaitTime());
    }

    IEnumerator WaitTime()
    {
        audioManager.PlaySFX(audioManager.menuBars);
        yield return new WaitForSeconds(2f);
        animatorScreen.SetBool("IsStartGame", true);
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("Game");
    }

    public void ExitGame()
    {
        Debug.Log("Игра закрылась");
        Application.Quit();
    }
}
