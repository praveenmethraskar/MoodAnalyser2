using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser2;


namespace MSTest_MoodAnalyser
{
    [TestClass]
    public class UnitTest1
    {
        //Test Case 1.1  Given I am in Sad Mood Message Should return Sad Mood

        [TestMethod]
        public void GivenSADMood_ShouldReturnSAD()
        {

            //Arrange

            string message = "I am in Sad Mood";
            MoodAnalyser obj = new MoodAnalyser(message);

            string expected = "Sad";

            //Act

            string actual = obj.AnalyseMood();

            //Assert

            Assert.AreEqual(expected, actual);
        }


        //Test Case 1.2  Given I am in Happy Mood Message Should return Happy Mood

        [TestMethod]
        public void GivenHappyMoodMessage_ShouldReturnHAPPY()
        {

            //Arrange

            string message = "I am in Happy Mood";
            MoodAnalyser obj = new MoodAnalyser(message);

            string expected = "Happy";

            //Act

            string actual = obj.AnalyseMood();

            //Assert

            Assert.AreEqual(expected, actual);
        }

        //Test Case 2.1 Given Null Mood Should Return Happy

        [TestMethod]
        public void GivenNullMood_ShouldReturnHAPPY()
        {

            //Arrange

            string message = null;
            MoodAnalyser obj = new MoodAnalyser(message);

            //Act

            string actual = obj.AnalyseMood();

            //Assert

            Assert.AreEqual(actual, "Happy");
        }
    }
}