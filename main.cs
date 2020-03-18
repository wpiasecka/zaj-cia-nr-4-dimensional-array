using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
  }
}

int x, y, pX, pY
string valX,valY, playerX, playerY, sign;
Console.WriteLine("Put x dimension of board:");
valX = Console.ReadLine();
Console.WriteLine("Put y dimension of board:");
valY = Console.ReadLine();

// convert to integer
x = Convert.ToInt32(valX);
y = Convert.ToInt32(valY);

//create 2D board
string[,] board = new string[x, y];

string star = "*";

// fil board with *
for (int i = 0; i < x; i++) {
  for (int j = 0; j < y; j++ ) {
    board[i, j] = star;
  }
}



//Display board as an string matrix ex.
/*
 * * * * *
 * * * * *
 * * * * *
 */ 
 for (int row = 0; row < x; row++){
   for (int col = 0; col < y; col++){
     Console.Write(String.Format("{0}\t" , board[row,col]));
   }
   Console.WriteLine();
 }

 // ask player to select row and colum
    Console.WriteLine("Put sign");
    sign = Console.ReadLine();
    Console.WriteLine("Put X:");
    playerX = Console.ReadLine();
    Console.WriteLine("Put Y dimension of board:");
    playerY = Console.ReadLine();

// convert to integer
pX = Convert.ToInt32(playerX);
pY = Convert.ToInt32(playerY);
 
 board[pX-1,pY-1] = sign;
 //Insert player representation into board ex.
 /*
 * * * * *
 * p * * *
 * * * * *
 */

 //show board 
 for (int row= 0; row < x; row++){
   for (int col = 0; col < y; col++){
     Console.Write(String.Format("{0"\t", board[row,col]));
   }
   Console.WriteLine();
 }



 //Use function Console.ReadKey(true) to fetch currently user pressed key, remember to assing function result to a variable then compare 