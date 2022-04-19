using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuController : MonoBehaviour
{
    public int currentNight;
    public bool unlockedExtras;

    public Button continueButton;
    public TMP_Text continueText;
    public Button extrasButton;

    public GameObject loadingText;
    // Start is called before the first frame update
    void Start()
    {
        currentNight = PlayerPrefs.GetInt("Night", 0);
        if(currentNight < 1){
            continueButton.interactable = false;
            continueText.enabled = false;
        }
        continueText.text = "Night " + currentNight;
        unlockedExtras = PlayerPrefs.GetInt("DidComplete", 0) == 1 ? true : false;
        if(!unlockedExtras){
            extrasButton.interactable = false;
        }
    }

  public void NewGame(){
      PlayerPrefs.SetInt("Night", 1);
      Load();
  }

  public void Load(){
      loadingText.SetActive(true);
      SceneManager.LoadSceneAsync("Game");
  }

  public void Exit(){
      Application.Quit();
  }
}
