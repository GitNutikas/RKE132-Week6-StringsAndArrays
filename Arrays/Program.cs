//string[] fruit = { "apples", "bananas", "oranges" };
string[] fruit = new string[3];

fruit[0] = "apples";
fruit[1] = "bananas";
fruit[2] = "oranges";
//Console.WriteLine($"{fruit[0]}, {fruit[1]}, {fruit[2]}");

int fruitArrayLength = fruit.Length;
Console.WriteLine($"There are {fruitArrayLength} in your area.");

//for ( int i = 0; i < fruitArrayLength; i++)
//{
//    Console.WriteLine(fruit[i]);
//}

//foreach(string element in fruit)    //foreach - ei sa kasutada kui on vaja midagi muuta sisuliselt (sisu), näiteks replace väike täht suureks
//{
//    Console.WriteLine(element);
//}

for (int i = 0; i < fruitArrayLength; i++)
{
    fruit[i] = fruit[i].Replace(fruit[i][0], char.ToUpper(fruit[i][0]));
    Console.WriteLine(fruit[i]);
}