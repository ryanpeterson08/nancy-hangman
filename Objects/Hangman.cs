using System;
using System.Collections.Generic;
namespace Hangman.Objects
{
  public class State
  {
    private static List<State> _states = new List<State>{};
    private static List<string> _wordBank = new List<string>{"turkey", "gravy", "corn", "cranberry", "pumpkin"};
    private static string _computerWord;
    private string _currentLetter;
    private string _blankString;
    private List<string> _blanks = new List<string>{};
    private List<string> _lettersGuessed = new List<string>{};
    private int _guessesLeft;
    private bool _gameOver;

    public State()
    {
      _computerWord = _wordBank[this.GetRandom()];
      _guessesLeft = 6;
      _gameOver = false;
      _states.Add(this);
      _lettersGuessed.Add(" ");
    }
    public List<string> GetWordBank()
    {
      return _wordBank;
    }
    public void SetWordBank(List<string> wordBank)
    {
      _wordBank = wordBank;
    }

    public string GetComputerWord()
    {
      return _computerWord;
    }
    public void SetComputerWord(string computerWord)
    {
      _computerWord = computerWord;
    }

    public static List<State> GetStates()
    {
      return _states;
    }
    public static void SaveState(State state)
    {
      _states.Add(state);
    }

    public List<string> GetBlanks()
    {
      return _blanks;
    }
    public void MakeBlanks() {
      for(int i = 0; i < this.GetComputerWord().Length; i++)
      {
         _blanks.Add("_");
      }
    }

    public string GetBlankString()
    {
      return _blankString;
    }
    public void SetBlankString()
    {
      _blankString = String.Join(" ", _blanks);
    }

    public void CheckLetter()
    {
      for(int x = 0; x < _computerWord.Length; x++)
      {
        if(_currentLetter == _computerWord[x].ToString())
        {
          _blanks[x] = _currentLetter;
          System.Console.WriteLine(x);
        }
      }
    }

    public int GetGuessesLeft()
    {
      return _guessesLeft;
    }
    public void SetGuessesLeft()
    {
      _guessesLeft--;
    }

    public List<string> GetLettersGuessed()
    {
      return _lettersGuessed;
    }
    public void SetLettersGuessed()
    {
      _lettersGuessed.Add(_currentLetter);
    }

    public bool GetGameOver()
    {
      return _gameOver;
    }
    public void SetGameOver(bool gameOver)
    {
      _gameOver = true;
    }

    public string GetCurrentLetter()
    {
      return _currentLetter;
    }
    public void SetCurrentLetter(string currentLetter)
    {
      _currentLetter = currentLetter;
    }

    public int GetRandom()
    {
      Random random = new Random();
      int randomNum = random.Next(5);
      return randomNum;
    }
  }
}
