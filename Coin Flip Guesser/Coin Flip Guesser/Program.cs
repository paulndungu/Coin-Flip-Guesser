WriteLine("-----------------");
WriteLine("Coin Flip Guesser");
WriteLine("-----------------\n");
//Write("Input a character between a and c: ");
//char userPrompt = ReadKey().KeyChar;
//WriteLine();
Random randomize=new Random();
char userPrompt = (char)randomize.Next('a', 'c');
WriteLine($"With the character ({userPrompt}), the result of the flip is {(userPrompt=='a'?true:false)}");