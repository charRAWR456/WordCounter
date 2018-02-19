using System;
using System.Text;
using System.Collections.Generic;

namespace WordCounter
{
  public class WordCount
  {
    private string _reEnter = "Please enter a word AND sentence";

    public int RepeatCounter(string _word, string _sentence)
    {
      int wordCount = 0;
      _sentence = _sentence.ToLower();
      _word = _word.ToLower();
      string newSentence = _sentence;
      string[] sentenceWord = newSentence.ToLower().Split();

      for(int i = 0; i < sentenceWord.Length; i++)
      {
        if (sentenceWord[i] == _word)
        {
          wordCount += 1;
        }
      }
      return wordCount;
    }
    
    public string FieldCheck(string _word, string _sentence)
    {
      if(_word.Length == 0 || _sentence.Length == 0)
      {
        return _reEnter;
      }
      return "hi";
    }
  }
}
