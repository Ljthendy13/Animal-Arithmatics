using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveController : MonoBehaviour
{
    public static SaveController Instance;

    public int numberOfHeartsOwned = 1;
    public int numberOfGemsOwned;

    public int boolLevel1Beat;
    public int boolLevel2Beat;
    public int boolLevel3Beat;
    public int boolLevel4Beat;
    public int boolLevel5Beat;

    void Start()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);

        numberOfHeartsOwned = PlayerPrefs.GetInt("numberOfHeartsOwned");
        numberOfGemsOwned = PlayerPrefs.GetInt("numberOfGemsOwned");

        boolLevel1Beat = PlayerPrefs.GetInt("boolLevel1Beat");
        boolLevel2Beat = PlayerPrefs.GetInt("boolLevel2Beat");
        boolLevel3Beat = PlayerPrefs.GetInt("boolLevel3Beat");
        boolLevel4Beat = PlayerPrefs.GetInt("boolLevel4Beat");
        boolLevel5Beat = PlayerPrefs.GetInt("boolLevel5Beat");
    }

    public void ForceSave()
    {
        PlayerPrefs.SetInt("numberOfHeartsOwned", numberOfHeartsOwned);
        PlayerPrefs.SetInt("numberOfGemsOwned", numberOfGemsOwned);

        PlayerPrefs.SetInt("boolLevel1Beat", boolLevel1Beat);
        PlayerPrefs.SetInt("boolLevel2Beat", boolLevel2Beat);
        PlayerPrefs.SetInt("boolLevel3Beat", boolLevel3Beat);
        PlayerPrefs.SetInt("boolLevel4Beat", boolLevel4Beat);
        PlayerPrefs.SetInt("boolLevel5Beat", boolLevel5Beat);
    }

    public void ResetSave()
    {
        PlayerPrefs.SetInt("numberOfHeartsOwned", 0);
        PlayerPrefs.SetInt("numberOfGemsOwned", 0);

        PlayerPrefs.SetInt("boolLevel1Beat", 0);
        PlayerPrefs.SetInt("boolLevel2Beat", 0);
        PlayerPrefs.SetInt("boolLevel3Beat", 0);
        PlayerPrefs.SetInt("boolLevel4Beat", 0);
        PlayerPrefs.SetInt("boolLevel5Beat", 0);
    }
}
