using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser2;


namespace MSTest_MoodAnalyser
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenIamInSADMood_ShouldReturnSAD()
        {
            //Test Case 1.1  Given I am in Sad Mood Should return Sad Mood

            //Arrange

            MoodAnalyser obj = new MoodAnalyser();

            string message = "I am in Sad Mood";                 //we can also pass this message directly in the object

            string expected = "Sad Mood";

            //Act

            string actual = obj.AnalyseMood(message);

            //Assert

            Assert.AreEqual(expected, actual);
        }

    }
}