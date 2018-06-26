using System;
using System.Collections.Generic;

class Triangle
{
  private int _sideOne;
  private int _sideTwo;
  private int _sideThree;

  public void SetSides(int[] sides)
  {
    _sideOne = sides[0];
    _sideTwo = sides[1];
    _sideThree = sides[2];
  }

  public bool IsTriangle()
  {
    if ((_sideOne + _sideTwo <= _sideThree) || (_sideTwo + _sideThree <= _sideOne) || (_sideThree + _sideOne <= _sideTwo))
    {
      return false;
    }
    else
    {
      return true;
    }
  }

  public string WhichType()
  {
    if ((_sideOne == _sideTwo) && (_sideTwo == _sideThree))
    {
      return "equilateral";
    }
    if ((_sideOne == _sideTwo) || (_sideTwo == _sideThree) || (_sideOne == _sideThree))
    {
      return "isosceles";
    }
    else
    {
      return "scalene";
    }
  }
}

public class Program
{
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
    Triangle ourTriangle = new Triangle();
    ourTriangle.SetSides(sides);
    if (ourTriangle.IsTriangle())
    {
      Console.WriteLine(ourTriangle.WhichType());
    }
  }
}
