using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (questionUp == false)
        {
            int currentQuestion = Random.Range(0,10);
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
    }

    public void AnsweredOne()
    {
        if (currentQuestion == 0)
        {
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
        if (currentQuestion == 8)
        {
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
            answeredTen = true;
            questionUp = false;
        }
        else
        {
            Debug.Log("Wrong Answer.");
        }
    }
}
