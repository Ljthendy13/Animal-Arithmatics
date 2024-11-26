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
                int currentQuestion = new random.randint(0,9);
            }
    }
}
