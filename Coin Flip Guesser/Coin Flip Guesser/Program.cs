﻿WriteLine("-----------------");
WriteLine("Coin Flip Guesser");
WriteLine("-----------------\n");
//Write("Input a character between h and d: ");
//char userPrompt = ReadKey().KeyChar;
//WriteLine();
Random randomize=new Random();
char userPrompt = (char)randomize.Next('h', 'd');
WriteLine($"With the character ({userPrompt}), the result of the flip is {(userPrompt=='h'?"heads":"tails")}");