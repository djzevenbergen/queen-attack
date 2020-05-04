using System;

class Queen
{
  static void Main()
  {
    Console.WriteLine("Please enter an X coordinate for your Chesspiece");
    int userInputXCoord = int.Parse(Console.ReadLine());
    Console.WriteLine(userInputXCoord);

    Console.WriteLine("Please enter a Y coordinate for your Chesspiece");
    int userInputYCoord = int.Parse(Console.ReadLine());

    Console.WriteLine("Please enter and X coordinate for the Queen");
    int queenInputXCoord = int.Parse(Console.ReadLine());

    Console.WriteLine("Please enter a Y coordinate for the Queen");
    int queenInputYCoord = int.Parse(Console.ReadLine());

    bool notSafe = QueenCheck(userInputXCoord, userInputYCoord, queenInputXCoord, queenInputYCoord);

  if(notSafe == true)
  {
    Console.WriteLine("You are not safe from Queeny");
  }
  else
  {
    Console.WriteLine("You're safe from Queeny... for now.");
  }
  }

  static bool QueenCheck(int userX, int userY, int queenX, int queenY)
  {
    if (userX == queenX)
    {
      return true;
    }
    else if (userY == queenY)
    {
      return true;
    }
    else if ((userX-queenX)/(userY-queenY) == 1)
    {
      return true;
    } 
    else
    {
      return false;
    }
  }
}



//     a    b    c    d    e    f    g    h
//  1 a1   b1   c1   d1    e1   f1   g1   h1
//  2 a2   b2   c2   d2    e2   f2   g2   h2
//  3 a3   b3   c3   d3    e3   f3   g3   h3
//  4 a4   b4   c4   d4    e4   f4   g4   h4
//  5 a5   b5   c5   d5    e5   f5   g5   h5
//  6 a6   b6   c6   d6    e6   f6   g7   h7
//  7 a7   b7   c7   d7    e7   f7   g7   h7
//  8 a8   b8   c8   d8    e8   f8   g8   h8


// if they are on the same x coord as the queen return true
// if they are on the same y coord as the queen return true
// if the difference between the x coords/difference between the y coords = 1 



// (0 , 0) (1, 0)  (2, 0) (3, 0)
// (0,  1) (1, 1)  (2, 1) (3, 1)
// (0,  2) (1, 2)  (2, 2) (3, 2) 