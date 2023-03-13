namespace StringUtility
{
    public class StringUtility
    {


         public int CountOccurences(string stringToCheck, string stringToFind)
         {

            if (stringToCheck == null || stringToFind == null)
            {
                return -1;
                //throw new ArgumentNullException();
                }
            var stringAsCharArray = stringToCheck.ToCharArray();
            if (stringAsCharArray.Length == 0 )
            {
                return -1;
                //throw new ArgumentOutOfRangeException("Out of Range");
                
            }
            if (stringToFind.Length == 2 && stringToCheck.Length == 1 || stringToFind.Length == 1 && stringToCheck.Length == 2)
            {
                return -1;
               // throw new ArgumentOutOfRangeException("Out of Range");
            }
            
            var stringToCheckForAsChar = stringToFind.ToCharArray()[0];
               var occuranceCount = 0;
               for (var characterIndex = 0; characterIndex <= stringAsCharArray.GetUpperBound(0); characterIndex++)
               {
                     if (stringAsCharArray[characterIndex] == stringToCheckForAsChar)
                     {
                        occuranceCount++;
    
                     }
                    
                   
                
                }
            return occuranceCount;
         }

    }
}