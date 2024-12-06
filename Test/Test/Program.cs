using NUnit.Framework;
using UnityEngine;

public class QuestionsTests
{
    private Questions questions;

    [SetUp]
    public void SetUp()
    {
        // Initialize the Questions object
        GameObject testGameObject = new GameObject();
        questions = testGameObject.AddComponent<Questions>();
    }

    [Test]
    public void Test_QuestionUp_IsSet_WhenUnansweredQuestionSelected()
    {
        // Arrange
        questions.answeredOne = false;

        // Act
        questions.questionUp = false;
        questions.Update(); // Simulate Update to trigger question selection logic

        // Assert
        Assert.IsTrue(questions.questionUp);
    }

    [Test]
    public void Test_AnsweredOne_SetsCorrectFlags()
    {
        // Arrange
        questions.answeredOne = false;
        questions.questionUp = true;
        int simulatedQuestion = 0; // Simulating that the first question is selected
        typeof(Questions).GetField("currentQuestion", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).SetValue(questions, simulatedQuestion);

        // Act
        questions.AnsweredOne();

        // Assert
        Assert.IsTrue(questions.answeredOne);
        Assert.IsFalse(questions.questionUp);
    }

    [Test]
    public void Test_AnsweredWrongQuestion_LogsError()
    {
        // Arrange
        questions.answeredOne = false;
        questions.questionUp = true;
        int simulatedQuestion = 1; // Simulating that the second question is selected
        typeof(Questions).GetField("currentQuestion", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).SetValue(questions, simulatedQuestion);

        // Act & Assert
        LogAssert.Expect(LogType.Log, "Wrong Answer.");
        questions.AnsweredOne();
    }

    [Test]
    public void Test_AllQuestionsAnswered_QuestionUpRemainsFalse()
    {
        // Arrange
        questions.answeredOne = true;
        questions.answeredTwo = true;
        questions.answeredThree = true;
        questions.answeredFour = true;
        questions.answeredFive = true;
        questions.answeredSix = true;
        questions.answeredSeven = true;
        questions.answeredEight = true;
        questions.answeredNine = true;
        questions.answeredTen = true;

        // Act
        questions.Update();

        // Assert
        Assert.IsFalse(questions.questionUp);
    }
}
