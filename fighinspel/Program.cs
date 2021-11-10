using System;

int playerOneHp = 100;
int playerTowHp = 100;

Random generator = new Random();

while (playerOneHp > 0 && playerTowHp > 0)
{
Console.WriteLine();
Console.WriteLine();


int PlayerOneDamage = generator.Next(15);
playerTowHp -= PlayerOneDamage;
playerTowHp = Math.Max(0,playerTowHp);
Console.WriteLine();

int playerTowDamage = generator.Next(15);
playerOneHp -= playerTowDamage;
playerOneHp = Math.Max(0,playerOneHp);

Console.WriteLine();
Console.ReadKey();
}

