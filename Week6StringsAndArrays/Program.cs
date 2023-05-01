//string hello = " hello, World! Here I am!";
string hello = " we are the champions?";

int stringLength = hello.Length;
//Console.WriteLine(stringLength);

//string trimmedString = hello.Trim();
//Console.WriteLine(trimmedString.Length);

hello = hello.Trim();
//Console.WriteLine(hello.Length);

char firstLetter = hello[0];
//Console.WriteLine(firstLetter);
//hello = hello.Replace(hello[0], 'H');
//hello = hello.Replace(hello[0], char.ToUpper(hello[0]));
hello = hello.Replace(hello[0], char.ToUpper(hello[0])).Replace('?', '!');
//firstLetter = hello[0];
//Console.WriteLine(firstLetter);
Console.WriteLine(hello);

//int wordCounter = 1;
//for (int i = 0; i < hello.Length; i++)
//{
    //Console.WriteLine($"{i} symbol in string: {hello[i]}");
    
    //if (hello[i] == ' ')
    //{
    //    wordCounter++;
    //}

    //if (char.IsWhiteSpace(hello[i]))
    //{
    //    wordCounter++;
    //}
//}
//Console.WriteLine($"Word count in {hello}: {wordCounter} words.");