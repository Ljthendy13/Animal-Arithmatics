using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Shop : MonoBehaviour
{
    public GameObject SaveHolder;
    public SaveController SaveController;

    public GameObject buyButton;

    void Start()
    {
        SaveHolder = GameObject.Find("SaveHolder");

        SaveController = SaveHolder.GetComponent<SaveController>();
    }

    void Update()
    {
        if (SaveController.numberOfGemsOwned > 0)
        {
            buyButton.SetActive(true);
        }
        else
        {
            buyButton.SetActive(false);
        }
    }

    public void Back()
    {
        SceneManager.LoadScene("LevelSelect");
    }

    public void Buy()
    {
        SaveController.numberOfGemsOwned--;
        SaveController.numberOfHeartsOwned++;
        SaveController.ForceSave();
    }
}
