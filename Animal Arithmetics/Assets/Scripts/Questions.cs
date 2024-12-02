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

    // Start is called before the first frame update
    void Start()
    {
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
                    questionUp = true;
                }
            }
            if (currentQuestion == 1)
            {
                if (answeredTwo == false)
                {
                    questionUp = true;
                }
            }
            if (currentQuestion == 2)
            {
                if (answeredThree == false)
                {
                    questionUp = true;
                }
            }
            if (currentQuestion == 3)
            {
                if (answeredFour == false)
                {
                    questionUp = true;
                }
            }
            if (currentQuestion == 4)
            {
                if (answeredFive == false)
                {
                    questionUp = true;
                }
            }
            if (currentQuestion == 5)
            {
                if (answeredSix == false)
                {
                    questionUp = true;
                }
            }
            if (currentQuestion == 6)
            {
                if (answeredSeven == false)
                {
                    questionUp = true;
                }
            }
            if (currentQuestion == 7)
            {
                if (answeredEight == false)
                {
                    questionUp = true;
                }
            }
            if (currentQuestion == 8)
            {
                if (answeredNine == false)
                {
                    questionUp = true;
                }
            }
            if (currentQuestion == 9)
            {
                if (answeredTen == false)
                {
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
                                                Debug.Log("Level Cleared.");
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
            barOne.SetActive(false);
            answeredOne = true;
            questionUp = false;
        }
        else
        {
            Debug.Log("Wrong Answer.");
        }
    }

    public void AnsweredTwo()
    {
        if (currentQuestion == 1)
        {
            barTwo.SetActive(false);
            answeredTwo = true;
            questionUp = false;
        }
        else
        {
            Debug.Log("Wrong Answer.");
        }
    }

    public void AnsweredThree()
    {
        if (currentQuestion == 2)
        {
            barThree.SetActive(false);
            answeredThree = true;
            questionUp = false;
        }
        else
        {
            Debug.Log("Wrong Answer.");
        }
    }

    public void AnsweredFour()
    {
        if (currentQuestion == 3)
        {
            barFour.SetActive(false);
            answeredFour = true;
            questionUp = false;
        }
        else
        {
            Debug.Log("Wrong Answer.");
        }
    }

    public void AnsweredFive()
    {
        if (currentQuestion == 4)
        {
            barFive.SetActive(false);
            answeredFive = true;
            questionUp = false;
        }
        else
        {
            Debug.Log("Wrong Answer.");
        }
    }

    public void AnsweredSix()
    {
        if (currentQuestion == 5)
        {
            barSix.SetActive(false);
            answeredSix = true;
            questionUp = false;
        }
        else
        {
            Debug.Log("Wrong Answer.");
        }
    }

    public void AnsweredSeven()
    {
        if (currentQuestion == 6)
        {
            barSeven.SetActive(false);
            answeredSeven = true;
            questionUp = false;
        }
        else
        {
            Debug.Log("Wrong Answer.");
        }
    }

    public void AnsweredEight()
    {
        if (currentQuestion == 7)
        {
            barEight.SetActive(false);
            answeredEight = true;
            questionUp = false;
        }
        else
        {
            Debug.Log("Wrong Answer.");
        }
    }

    public void AnsweredNine()
    {
        if (currentQuestion == 8)
        {
            barNine.SetActive(false);
            answeredNine = true;
            questionUp = false;
        }
        else
        {
            Debug.Log("Wrong Answer.");
        }
    }

    public void AnsweredTen()
    {
        if (currentQuestion == 9)
        {
            barTen.SetActive(false);
            answeredTen = true;
            questionUp = false;
        }
        else
        {
            Debug.Log("Wrong Answer.");
        }
    }
}
