using System;
using System.Collections.Generic;

class Triangle
{

  public int sideOne;
  public int sideTwo;
  public int sideThree;

  public static void Main()
  {
    int[] sides = {0, 0, 0};
    for (int index = 0; index < 3; ++index)
    {
      Console.WriteLine("Enter a number for side " + (index + 1) + " of the triangle: ");
      string stringSide = Console.ReadLine();
      int side = int.Parse(stringSide);
      sides[index] = side;
    }
    Console.WriteLine("The sides are: " + sides[0] + "," + sides[1] + "," + sides[2]);
  }
}
