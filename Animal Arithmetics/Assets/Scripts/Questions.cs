using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Questions : MonoBehaviour
{
    public string questionOne = "Question One";
    public string questionTwo = "Question Two";
    public string questionThree = "Question Three";
    public string questionFour = "Question Four";
    public string questionFive = "Question Five";
    public string questionSix = "Question Six";
    public string questionSeven = "Question Seven";
    public string questionEight = "Question Eight";
    public string questionNine = "Question Nine";
    public string questionTen = "Question Ten";
    
    public string answerOne = "Answer One";
    public string answerTwo = "Answer Two";
    public string answerThree = "Answer Three";
    public string answerFour = "Answer Four";
    public string answerFive = "Answer Five";
    public string answerSix = "Answer Six";
    public string answerSeven = "Answer Seven";
    public string answerEight = "Answer Eight";
    public string answerNine = "Answer Nine";
    public string answerTen = "Answer Ten";
    
    public bool answeredOne = false;
    public bool answeredTwo = false;
    public bool answeredThree = false;
    public bool answeredFour = false;
    public bool answeredFive = false;
    public bool answeredSix = false;
    public bool answeredSeven = false;
    public bool answeredEight = false;
    public bool answeredNine = false;
    public bool answeredTen = false;
    
    public bool questionUp = false;

    public int currentQuestion = 0;
    public string currentQuestionText = "";

    public GameObject barOne;
    public GameObject barTwo;
    public GameObject barThree;
    public GameObject barFour;
    public GameObject barFive;
    public GameObject barSix;
    public GameObject barSeven;
    public GameObject barEight;
    public GameObject barNine;
    public GameObject barTen;

    public GameObject barOneReal;
    public GameObject barTwoReal;
    public GameObject barThreeReal;
    public GameObject barFourReal;
    public GameObject barFiveReal;
    public GameObject barSixReal;
    public GameObject barSevenReal;
    public GameObject barEightReal;
    public GameObject barNineReal;
    public GameObject barTenReal;

    public GameObject questionText;

    public AudioSource Correct;
    public AudioSource Incorrect;
    public AudioSource Treasure;
    public AudioSource FieldMusic;
    public AudioSource LakesideMusic;
    public AudioSource DnightMusic;
    public AudioSource DwoodMusic;
    public AudioSource CwallMusic;

    public GameObject pet1;
    public GameObject pet2;
    public GameObject pet3;
    public GameObject pet4;
    public GameObject pet5;
    public AudioSource pet1Sound;
    public AudioSource pet2Sound;
    public AudioSource pet3Sound;
    public AudioSource pet4Sound;
    public AudioSource pet5Sound;

    public bool won = false;
    public GameObject wonText;
    public GameObject gemText;
    public GameObject gemController;

    // Start is called before the first frame update
    void Start()
    {
        Scene scene = SceneManager.GetActiveScene();

        Correct = GameObject.Find("CorrectSoundController").GetComponent<AudioSource>();
        Incorrect = GameObject.Find("IncorrectSoundController").GetComponent<AudioSource>();
        Treasure = GameObject.Find("TreasureSoundController").GetComponent<AudioSource>();

        pet1 = GameObject.Find("pet 1");
        pet2 = GameObject.Find("pet 2");
        pet3 = GameObject.Find("pet 3");
        pet4 = GameObject.Find("pet 4");
        pet5 = GameObject.Find("pet 5");
        pet1Sound = pet1.GetComponent<AudioSource>();
        pet2Sound = pet2.GetComponent<AudioSource>();
        pet3Sound = pet3.GetComponent<AudioSource>();
        pet4Sound = pet4.GetComponent<AudioSource>();
        pet5Sound = pet5.GetComponent<AudioSource>();

        pet1.SetActive(false);
        pet2.SetActive(false);
        pet3.SetActive(false);
        pet4.SetActive(false);
        pet5.SetActive(false);

        wonText = GameObject.Find("WonText");
        wonText.SetActive(false);
        gemText = GameObject.Find("GemText");
        gemText.SetActive(false);
        gemController = GameObject.Find("GemController");
        gemController.SetActive(false);

        if (scene.name == "Level 1")
        {
            pet1.SetActive(true);
            FieldMusic = GameObject.Find("FieldSoundController").GetComponent<AudioSource>();
            FieldMusic.Play();
            questionOne = "What is 2 + 1?";
            questionTwo = "What is 3 + 2?";
            questionThree = "What is 5 - 1?";
            questionFour = "What is 6 - 4?";
            questionFive = "What is 4 + 4?";
            questionSix = "What is 8 - 2?";
            questionSeven = "What is 7 - 6?";
            questionEight = "What is 2 + 5?";
            questionNine = "What is 6 - 6?";
            questionTen = "What is 4 + 5?";

            answerOne = "3";
            answerTwo = "5";
            answerThree = "4";
            answerFour = "2";
            answerFive = "8";
            answerSix = "6";
            answerSeven = "1";
            answerEight = "7";
            answerNine = "0";
            answerTen = "9";
        }
        else if (scene.name == "Level 2")
        {
            pet2.SetActive(true);
            LakesideMusic = GameObject.Find("LakesideSoundController").GetComponent<AudioSource>();
            LakesideMusic.Play();
            questionOne = "What is 7 + 3?";
            questionTwo = "What is 10 - 4?";
            questionThree = "What is 9 - 5?";
            questionFour = "What is 8 + 6?";
            questionFive = "What is 10 + 2?";
            questionSix = "What is 14 - 7?";
            questionSeven = "What is 5 + 6?";
            questionEight = "What is 9 + 3?";
            questionNine = "What is 12 - 9?";
            questionTen = "What is 15 - 7?";

            answerOne = "10";
            answerTwo = "6";
            answerThree = "4";
            answerFour = "14";
            answerFive = "12";
            answerSix = "7";
            answerSeven = "11";
            answerEight = "12";
            answerNine = "3";
            answerTen = "8";
        }
        else if (scene.name == "Level 3")
        {
            pet3.SetActive(true);
            DnightMusic = GameObject.Find("DnightSoundController").GetComponent<AudioSource>();
            DnightMusic.Play();
            questionOne = "What is 3 x 2?";
            questionTwo = "What is 4 x 2?";
            questionThree = "What is 12 ÷ 3?";
            questionFour = "What is 6 x 2?";
            questionFive = "What is 9 ÷ 3?";
            questionSix = "What is 7 x 2?";
            questionSeven = "What is 8 ÷ 4?";
            questionEight = "What is 10 ÷ 2?";
            questionNine = "What is 5 x 3?";
            questionTen = "What is 20 ÷ 2?";

            answerOne = "6";
            answerTwo = "8";
            answerThree = "4";
            answerFour = "12";
            answerFive = "3";
            answerSix = "14";
            answerSeven = "2";
            answerEight = "5";
            answerNine = "15";
            answerTen = "10";
        }
        else if (scene.name == "Level 4")
        {
            pet4.SetActive(true);
            DwoodMusic = GameObject.Find("DwoodSoundController").GetComponent<AudioSource>();
            DwoodMusic.Play();
            questionOne = "What is 8 x 3?";
            questionTwo = "What is 18 ÷ 6?";
            questionThree = "What is 6 x 5?";
            questionFour = "What is 24 ÷ 4?";
            questionFive = "What is 7 x 5?";
            questionSix = "What is 20 ÷ 5?";
            questionSeven = "What is 9 x 2?";
            questionEight = "What is 30 ÷ 6?";
            questionNine = "What is 12 x 3?";
            questionTen = "What is 40 ÷ 4?";

            answerOne = "24";
            answerTwo = "3";
            answerThree = "30";
            answerFour = "6";
            answerFive = "35";
            answerSix = "4";
            answerSeven = "18";
            answerEight = "5";
            answerNine = "36";
            answerTen = "10";
        }
        else if (scene.name == "Level 5")
        {
            pet5.SetActive(true);
            CwallMusic = GameObject.Find("CwallSoundController").GetComponent<AudioSource>();
            CwallMusic.Play();
            questionOne = "What is 12 x 3?";
            questionTwo = "What is 36 ÷ 6?";
            questionThree = "What is 8 x 4?";
            questionFour = "What is 32 ÷ 4?";
            questionFive = "What is 9 x 5?";
            questionSix = "What is 45 ÷ 5?";
            questionSeven = "What is 6 x 7?";
            questionEight = "What is 49 ÷ 7?";
            questionNine = "What is 5 x 7?";
            questionTen = "What is 55 ÷ 5?";

            answerOne = "36";
            answerTwo = "6";
            answerThree = "32";
            answerFour = "8";
            answerFive = "45";
            answerSix = "9";
            answerSeven = "42";
            answerEight = "7";
            answerNine = "35";
            answerTen = "11";
        }
        else
        {
            Debug.Log("You aren't supposed to be here.");
        }

        barOne = GameObject.Find("Bar1");
        barTwo = GameObject.Find("Bar2");
        barThree = GameObject.Find("Bar3");
        barFour = GameObject.Find("Bar4");
        barFive = GameObject.Find("Bar5");
        barSix = GameObject.Find("Bar6");
        barSeven = GameObject.Find("Bar7");
        barEight = GameObject.Find("Bar8");
        barNine = GameObject.Find("Bar9");
        barTen = GameObject.Find("Bar10");
        barOneReal = GameObject.Find("bar (1)");
        barTwoReal = GameObject.Find("bar (2)");
        barThreeReal = GameObject.Find("bar (3)");
        barFourReal = GameObject.Find("bar (4)");
        barFiveReal = GameObject.Find("bar (5)");
        barSixReal = GameObject.Find("bar (6)");
        barSevenReal = GameObject.Find("bar (7)");
        barEightReal = GameObject.Find("bar (8)");
        barNineReal = GameObject.Find("bar (9)");
        barTenReal = GameObject.Find("bar (10)");

        questionText = GameObject.Find("QuestionText");

        barOne.GetComponentInChildren<TMP_Text>().text = answerOne;
        barTwo.GetComponentInChildren<TMP_Text>().text = answerTwo;
        barThree.GetComponentInChildren<TMP_Text>().text = answerThree;
        barFour.GetComponentInChildren<TMP_Text>().text = answerFour;
        barFive.GetComponentInChildren<TMP_Text>().text = answerFive;
        barSix.GetComponentInChildren<TMP_Text>().text = answerSix;
        barSeven.GetComponentInChildren<TMP_Text>().text = answerSeven;
        barEight.GetComponentInChildren<TMP_Text>().text = answerEight;
        barNine.GetComponentInChildren<TMP_Text>().text = answerNine;
        barTen.GetComponentInChildren<TMP_Text>().text = answerTen;

        barOne.SetActive(true);
        barTwo.SetActive(true);
        barThree.SetActive(true);
        barFour.SetActive(true);
        barFive.SetActive(true);
        barSix.SetActive(true);
        barSeven.SetActive(true);
        barEight.SetActive(true);
        barNine.SetActive(true);
        barTen.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (questionUp == false)
        {
            currentQuestion = Random.Range(0,10);
            if (currentQuestion == 0)
            {
                if (answeredOne == false)
                {
                    currentQuestionText = questionOne;
                    questionText.GetComponent<TMP_Text>().text = currentQuestionText;
                    questionUp = true;
                }
            }
            if (currentQuestion == 1)
            {
                if (answeredTwo == false)
                {
                    currentQuestionText = questionTwo;
                    questionText.GetComponent<TMP_Text>().text = currentQuestionText;
                    questionUp = true;
                }
            }
            if (currentQuestion == 2)
            {
                if (answeredThree == false)
                {
                    currentQuestionText = questionThree;
                    questionText.GetComponent<TMP_Text>().text = currentQuestionText;
                    questionUp = true;
                }
            }
            if (currentQuestion == 3)
            {
                if (answeredFour == false)
                {
                    currentQuestionText = questionFour;
                    questionText.GetComponent<TMP_Text>().text = currentQuestionText;
                    questionUp = true;
                }
            }
            if (currentQuestion == 4)
            {
                if (answeredFive == false)
                {
                    currentQuestionText = questionFive;
                    questionText.GetComponent<TMP_Text>().text = currentQuestionText;
                    questionUp = true;
                }
            }
            if (currentQuestion == 5)
            {
                if (answeredSix == false)
                {
                    currentQuestionText = questionSix;
                    questionText.GetComponent<TMP_Text>().text = currentQuestionText;
                    questionUp = true;
                }
            }
            if (currentQuestion == 6)
            {
                if (answeredSeven == false)
                {
                    currentQuestionText = questionSeven;
                    questionText.GetComponent<TMP_Text>().text = currentQuestionText;
                    questionUp = true;
                }
            }
            if (currentQuestion == 7)
            {
                if (answeredEight == false)
                {
                    currentQuestionText = questionEight;
                    questionText.GetComponent<TMP_Text>().text = currentQuestionText;
                    questionUp = true;
                }
            }
            if (currentQuestion == 8)
            {
                if (answeredNine == false)
                {
                    currentQuestionText = questionNine;
                    questionText.GetComponent<TMP_Text>().text = currentQuestionText;
                    questionUp = true;
                }
            }
            if (currentQuestion == 9)
            {
                if (answeredTen == false)
                {
                    currentQuestionText = questionTen;
                    questionText.GetComponent<TMP_Text>().text = currentQuestionText;
                    questionUp = true;
                }
            }
        }

        if (answeredOne == true)
        {
            if (answeredTwo == true)
            {
                if (answeredThree == true)
                {
                    if (answeredFour == true)
                    {
                        if (answeredFive == true)
                        {
                            if (answeredSix == true)
                            {
                                if (answeredSeven == true)
                                {
                                    if (answeredEight == true)
                                    {
                                        if (answeredNine == true)
                                        {
                                            if (answeredTen == true)
                                            {
                                                if (won == false)
                                                {
                                                    StartCoroutine(Win());
                                                    wonText.SetActive(true);
                                                    won = true;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }

    public void AnsweredOne()
    {
        if (currentQuestion == 0)
        {
            Correct.Play();
            barOne.SetActive(false);
            barOneReal.SetActive(false);
            answeredOne = true;
            questionUp = false;
        }
        else
        {
            Incorrect.Play();
        }
    }

    public void AnsweredTwo()
    {
        if (currentQuestion == 1)
        {
            Correct.Play();
            barTwo.SetActive(false);
            barTwoReal.SetActive(false);
            answeredTwo = true;
            questionUp = false;
        }
        else
        {
            Incorrect.Play();
        }
    }

    public void AnsweredThree()
    {
        if (currentQuestion == 2)
        {
            Correct.Play();
            barThree.SetActive(false);
            barThreeReal.SetActive(false);
            answeredThree = true;
            questionUp = false;
        }
        else
        {
            Incorrect.Play();
        }
    }

    public void AnsweredFour()
    {
        if (currentQuestion == 3)
        {
            Correct.Play();
            barFour.SetActive(false);
            barFourReal.SetActive(false);
            answeredFour = true;
            questionUp = false;
        }
        else
        {
            Incorrect.Play();
        }
    }

    public void AnsweredFive()
    {
        if (currentQuestion == 4)
        {
            Correct.Play();
            barFive.SetActive(false);
            barFiveReal.SetActive(false);
            answeredFive = true;
            questionUp = false;
        }
        else
        {
            Incorrect.Play();
        }
    }

    public void AnsweredSix()
    {
        if (currentQuestion == 5)
        {
            Correct.Play();
            barSix.SetActive(false);
            barSixReal.SetActive(false);
            answeredSix = true;
            questionUp = false;
        }
        else
        {
            Incorrect.Play();
        }
    }

    public void AnsweredSeven()
    {
        if (currentQuestion == 6)
        {
            Correct.Play();
            barSeven.SetActive(false);
            barSevenReal.SetActive(false);
            answeredSeven = true;
            questionUp = false;
        }
        else
        {
            Incorrect.Play();
        }
    }

    public void AnsweredEight()
    {
        if (currentQuestion == 7)
        {
            Correct.Play();
            barEight.SetActive(false);
            barEightReal.SetActive(false);
            answeredEight = true;
            questionUp = false;
        }
        else
        {
            Incorrect.Play();
        }
    }

    public void AnsweredNine()
    {
        if (currentQuestion == 8)
        {
            Correct.Play();
            barNine.SetActive(false);
            barNineReal.SetActive(false);
            answeredNine = true;
            questionUp = false;
        }
        else
        {
            Incorrect.Play();
        }
    }

    public void AnsweredTen()
    {
        if (currentQuestion == 9)
        {
            Correct.Play();
            barTen.SetActive(false);
            barTenReal.SetActive(false);
            answeredTen = true;
            questionUp = false;
        }
        else
        {
            Incorrect.Play();
        }
    }

    public IEnumerator Win()
    {
        Scene scene = SceneManager.GetActiveScene();

        if (scene.name == "Level 1")
        {
            pet1Sound.Play();
        }

        yield return new WaitForSeconds(2);

        wonText.SetActive(false);
        gemText.SetActive(true);
        gemController.SetActive(true);
        Treasure.Play();

        yield return new WaitForSeconds(3);

        Debug.Log("Would Switch Scene");
    }
}
