﻿



char[] alphabet = new char[] { 'а', 'б', 'в', 'г', 'д', 'е', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ь', 'ы', 'ъ', 'э', 'ю', 'я' };
Console.WriteLine("Введите слово: ");
String text = Console.ReadLine();
text = text.ToLower();
String result = "";
int s = 0, k = 0;
Console.WriteLine("1 - Зашифровать \n2 - Расшифровать");
int a = Convert.ToInt32(Console.ReadLine());
switch (a)
{
    case 1:
        for (int i = 0; i < text.Length; i++)
        {   
            if (alphabet[i] != text[i])
            {
                Console.WriteLine("Неправильно ввёл");
                break;
            }
            
            for (int j = 0; j < alphabet.Length; j++)
            {
                if (text[i] == alphabet[j])
                {
                    s = j;
                    break;
                }
            }
            if (i == 0) result += text[i];
            else
            {
                s = s + i - 1;
                result += alphabet[s % alphabet.Length];

            }
        }
        Console.WriteLine("Зашифрованное слово: " + result);
        break;
    case 2:
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (alphabet[i] != text[i])
                {
                    Console.WriteLine("Неправильно ввёл");
                    break;
                }
 
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (text[i] == alphabet[j])
                    {
                        s = j;
                        break;
                    }
                }
                if (i == 0) result += text[i];
                else
                {
                    s = s - i - 1 % alphabet.Length;
                    if (s < 0) s = alphabet.Length + s;
                    result += alphabet[s];

                }


                Console.WriteLine("Расшифрованное слово: " + result);
            }
            break;
        }
}




