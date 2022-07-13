// Даны две строки. Определить можно ли из символов первой строки, собрать вторую. Допускается любое количество пробелов. Регистр символов различный в любой последовательности.
// Пример:
// Строка 1. Tom Marvolo Riddle
// Строка 2. I am Lord Voldemort
// Ответ: Да
// Строка 1. Tom Marvolo Riddle
// Строка 2. Lord Voldemort
// Ответ: Нет - остались свободные символы.

using System;
using static System.Console;
using System.Linq;
Clear();

string TextOne = "Tom Marvolo Riddle";
string TextTwo = "I am Lord Voldemort";
string TextThree = "Lord Voldemort";

WriteLine($"Строка 1 - {TextOne}");
WriteLine($"Строка 2 - {TextTwo}");
StringСomparison(TextOne, TextTwo);
WriteLine();
WriteLine($"Строка 1 - {TextOne}");
WriteLine($"Строка 2 - {TextThree}");
StringСomparison(TextOne, TextThree);

void StringСomparison(string firstText, string secondText)
{
   // Перобразуем символы строк
   string newFirstText = String.Concat(firstText.ToLower().Replace(" ", "").OrderBy(ch => ch));
   string newSecondText = String.Concat(secondText.ToLower().Replace(" ", "").OrderBy(ch => ch));

   if (newFirstText.Length == newSecondText.Length)
   {
      int count = 0;
      for (int i = 0; i < newFirstText.Length; i++)
      {
         if (newFirstText[i] == newSecondText[i]) count++;
      }
      if (count == newFirstText.Length) WriteLine("Да можно из символов первой строки, собрать вторую");
      else WriteLine("Нет - остались свободные символы.");
   }
   else WriteLine("Нет - остались свободные символы.");
}