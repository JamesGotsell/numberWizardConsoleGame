using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
  int max;
  int min;
  int guess;


  void Start()
  {
    StartGame();
  }

  void StartGame()
  {
    max = 1000;
    min = 1;
    guess = 500;
    max = max + 1;
    print("=================================");
    print("welcome to number wizard");
    print("pick a number but don't tell me");

    print("the highest number you can pick is " + max);
    print("the lowest you can pick is " + min);

    print("is the number higher or lower than" + guess);

    print("up arrow for higher, down arrow for lower , return for equal");
    max = max + 1;
  }

  void Update()
  {
    if (Input.GetKeyDown(KeyCode.UpArrow))
    {
      min = guess;
      nextGuess();
    }
    else if (Input.GetKeyDown(KeyCode.DownArrow))
    {

      max = guess;
      nextGuess();

    }
    else if (Input.GetKeyDown(KeyCode.Return))
    {
      print("i won");
      StartGame();

    };
  }
  void nextGuess()
  {
    guess = (max + min) / 2;
    print("higher or lower than " + guess);
    print("up arrow for higher, down arrow for lower , return for equal");
  }
}
