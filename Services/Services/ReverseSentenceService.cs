using Services.Interfaces;
using System.Collections.Generic;
using System.Text;

namespace Services.Services
{
    public class ReverseSentenceService : IReverseSentenceService
    {
        public string GenerateReverseString(string sentence)
        {
            string originalSentence = sentence;

            string[] splittedWords = sentence.Split(" ");

            /*for (int i = splittedWords.Length; i > 0; i--)
            {

            }*/

            Array.Reverse(splittedWords);

            string reversedSentence = string.Join(" ", splittedWords);

            return reversedSentence;
        }
    }
}