using System;
using System.Linq;

namespace MasterMind {
  class Program {
    static void Main() {
      Console.WriteLine("running...");
      Program program = new Program();
      program.Game();
    }
    public void Game() {

      int[] secretList = GenerateSecretList();
      int[] guess = Console.ReadLine().ToCharArray().Select(c => int.Parse(c.ToString())).ToArray();

      while ( !checkIfEqual(secretList, guess) ) { //If its not equal, keep doing this.
        Console.WriteLine("Is not equal");
        guess = Console.ReadLine().ToCharArray().Select(c => int.Parse(c.ToString())).ToArray();

        foreach ( var item in giveFeedback(guess, secretList) ) {
          Console.WriteLine(item);
        }
      }

    }
    static int[] GenerateSecretList() {
      Random random = new Random();
      int[] secretList = new int[] { random.Next(3), random.Next(3), random.Next(3), random.Next(3) };
      foreach ( int pin in secretList ) {
        Console.WriteLine(pin);
      }
      return secretList;
    }
    public bool checkIfEqual(int[] secretList, int[] guess) {
      for ( int i = 0;i < 3;i++ ) {
        if ( secretList[i] != guess[i] ) {
          return false;
        }
      }
      return true;
    }
    public int[] giveFeedback(int[] guess, int[] secret) {
      // empty = 0
      // right number wrong place = 1;
      // right number right place = 2;

      int[] feedback = new int[] { 0, 0, 0, 0 };
      for ( int position = 0;position < 4;position++ ) {
        for ( int subPosition = 0;subPosition < 4;subPosition++ ) {
          if ( secret[position] == guess[subPosition] ) {
            if ( position == subPosition ) {
              feedback[position] = 2;
              break; //end this iteration and move on
            } else {
              feedback[position] = 1;
            }
            // break;
          }
        }
      }
      return feedback;
    }
  }
}