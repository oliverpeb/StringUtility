using StringUtility;
namespace TestStringUtility
{
    [TestClass]
    public class TestStringUtility
    {
        
        [TestMethod]
        [DataRow(null, null, -1)]
        [DataRow(null, "", -1)]
        [DataRow(null, "1", -1)]
        [DataRow(null, "12", -1)]
        [DataRow("", null, -1)]
        [DataRow("", "", -1)]
        [DataRow("", "1", -1)]
        [DataRow("", "12", -1)]
        [DataRow("1", null, -1)]
        [DataRow("1", "", -1)]
        [DataRow("1", "1", 1)]
        [DataRow("1", "12", -1)]
        [DataRow("12", null, -1)]
        [DataRow("12", "", -1)]
        [DataRow("12", "1", -1)]
        [DataRow("12", "12", 1)]
        public void ShouldBeAbleToHandleNulls(string stringToCheck, string stringToFind, int expectedResult)
        {
            StringUtility.StringUtility classUnderTest = new StringUtility.StringUtility();
            int actualResult = classUnderTest.CountOccurences(stringToCheck, stringToFind);
            Assert.AreEqual(expectedResult, actualResult);
        }
       

    }
}
 
    
