using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    public GameObject SaveHolder;
    public SaveController SaveController;

    public GameObject level2Button;
    public GameObject level3Button;
    public GameObject level4Button;
    public GameObject level5Button;
    public GameObject level6Button;
    public GameObject shopButton;

    void Start()
    {
        SaveHolder = GameObject.Find("SaveHolder");

        SaveController = SaveHolder.GetComponent<SaveController>();

        level2Button.SetActive(false);
        level3Button.SetActive(false);
        level4Button.SetActive(false);
        level5Button.SetActive(false);
        level6Button.SetActive(false);

        if (SaveController.boolLevel1Beat == 1)
        {
            level2Button.SetActive(true);
        }
        if (SaveController.boolLevel2Beat == 1)
        {
            level3Button.SetActive(true);
        }
        if (SaveController.boolLevel3Beat == 1)
        {
            level4Button.SetActive(true);
        }
        if (SaveController.boolLevel4Beat == 1)
        {
            level5Button.SetActive(true);
        }
        if (SaveController.boolLevel5Beat == 1)
        {
            level6Button.SetActive(true);
        }
    }

    public void loadLevel1()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void loadLevel2()
    {
        SceneManager.LoadScene("Level 2");
    }

    public void loadLevel3()
    {
        SceneManager.LoadScene("Level 3");
    }

    public void loadLevel4()
    {
        SceneManager.LoadScene("Level 4");
    }

    public void loadLevel5()
    {
        SceneManager.LoadScene("Level 5");
    }

    public void loadLevel6()
    {
        SceneManager.LoadScene("Level 6");
    }

    public void loadShop()
    {
        SceneManager.LoadScene("Shop");
    }
}
