﻿// Вид 1
void Method1()
{
    Console.WriteLine("Автор Алексей");
}

Method1();

// Вид 2
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2(msg:"Текст сообщения");

// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     } 
// }
//Method21("Текст", 4);
//Method21(count: 4, msg: "новый Текст");

// Вид 3

int Method3()
{
    return DateTime.Now.Year;
}
int Year = Method3();
Console.WriteLine(Year);

// Вид 4

// string Method4(int count, string text)

// {
//     int i = 0;
//     string result = String.Empty;

//      while (i < count)
//      {
//         result = result + text;
//         i++;
//      }
//      return result;
// }

// string res = Method4(10, "z");
// Console.WriteLine(res);

string Method4(int count, string text)

{

    string result = String.Empty;
    for( int i = 0; i < count; i++)

     {
        result = result + text;
     }
     return result;
}

string res = Method4(10, "z");
Console.WriteLine(res);


for( int i = 2; i <= 10; i++)
{
    for (int j = 0; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}

string text = "Я помню чудное мгновенье: "
            + "Передо мной явилась ты, "
            + "Как мимолётное виденье, "
            + "Как гений чистой красоты.";

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }


    return result;
}

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(text, 'к', 'К');
Console.WriteLine(newText);