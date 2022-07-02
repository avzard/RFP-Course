using MoodAnalyser_MS;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MoodAnalyser_MS_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenSadMessage_WhenSad_ShouldReturnSAD()
        {
            //Arrange
            string Expected = "SAD";
            Program program = new Program("I am in Sad Mood");
            //Act
            string result = program.AnalyseMood();
            //Assert
            Assert.AreEqual(Expected, result);
        }
        [TestMethod]
        public void GivenHappyMessage_WhenAnyMood_ShouldReturnHAPPY()
        {
            //Arrange
            string Expected = "HAPPY";
            Program program = new Program("I am in Happy Mood");
            //Act
            string result = program.AnalyseMood();
            //Assert
            Assert.AreEqual(Expected, result);
        }
        [TestMethod]
        public void GivenAnyMessage_WhenAnyMood_ShouldReturnHAPPY()
        {
            //Arrange
            string Expected = "HAPPY";
            Program program = new Program("I am in Any Mood");
            //Act
            string result = program.AnalyseMood();
            //Assert
            Assert.AreEqual(Expected, result);
        }
        [TestMethod]
        [DataRow("null")]
        public void GivenNULLMessage_WhenANULL_ShouldReturnHAPPY(string message)
        {
            //Arrange
            string Expected = "Happy";
            Program moodAnalyser = new Program(message);
            //Act
            string result = moodAnalyser.AnalyseMood();
            //Assert
            Assert.AreEqual(Expected, result);
        }
        [TestMethod]
        [DataRow("")]
        public void GivenEmptyMessage_WhenEmpty_ShouldThrowException(string message)
        {
            try
            {
                //Arrange
                Program program = new Program(message);
                //Act
                string result = program.AnalyseMood();
                //Assert
            }
            catch (MoodAnalyserException e)
            {
                Assert.AreEqual("Mood should not be empty", e.Message);
            }

        }
    }
}
