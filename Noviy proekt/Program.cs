


String alphabet = "абвгдежзийклмнопрсттуфхцчшщьыъэюя";
Console.WriteLine("Введите слово: ");
String text = Console.ReadLine();
text = text.ToLower();
String result = "";
int s = 0;
Console.WriteLine("1 - Зашифровать \n2 - Расшифровать");
int a = Convert.ToInt32(Console.ReadLine());
switch (a)
{
    case 1:
        for (int i = 0; i < text.Length; i++)
        {
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
                s = s + text[i - 1];
                result += alphabet[s % alphabet.Length];
            }
        }
        Console.WriteLine("Зашифрованное слово: " + result);
        break;
    case 2:
        for (int i = 0; i < text.Length; i++)
        {
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
                s = s + text[i - 1];
                result += alphabet[alphabet.Length - (s % alphabet.Length)];
            }
        }
        Console.WriteLine("Расшифрованное слово: " + result);
        break;
}
        