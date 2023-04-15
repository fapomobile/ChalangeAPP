// See https://aka.ms/new-console-template for more informatio
int number = 8336;
string numer = number.ToString();
var nLiczba = numer.ToCharArray();


List<char> numbers = new List<char>();

numbers.Add('0');
numbers.Add('1');
numbers.Add('2');
numbers.Add('3');
numbers.Add('4');
numbers.Add('5');
numbers.Add('6');
numbers.Add('7');
numbers.Add('8');
numbers.Add('9');

for (char i ='0'; i < numbers.Count; i++)

//foreach(var numeros in numbers)
//{
 //   Console.WriteLine(numeros + "  Numery z listy");
//}
{
 //   Console.WriteLine(i);
}



char number1 = '0';
char number2 = '1';
char number3 = '2';
char number4 = '3';
char number5 = '4';
char number6 = '5';
char number7 = '6';
char number8 = '7';
char number9 = '8';
char number10 = '9';




char[] nNr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

Console.WriteLine(nLiczba.Count() + "  Ilość Liczb Max");

//Console.WriteLine(nNr[6] + "  Porównana liczba");
int nNumber0 = nNr[0];
int nNumber1 = nNr[1];
int nNumber2 = nNr[2];
int nNumber3 = nNr[3];
int nNumber4 = nNr[4];
int nNumber5 = nNr[5];
int nNumber6 = nNr[6];
int nNumber7 = nNr[7];
int nNumber8 = nNr[8];
int nNumber9 = nNr[9];

//for (var nNr1 = 0; nNr1 < nNr.Length; nNr1=nNr1+1) // i++
//{
//    Console.WriteLine(nNr[nNr1] + "  To ten numer powtarzamy");
//}

if (nLiczba.Contains <char>(number1))
{
    Console.WriteLine(number1);
}
 if (nLiczba.Contains<char>(number2))
{
    Console.WriteLine(number2);
}
 if (nLiczba.Contains<char>(number3))
{
    Console.WriteLine(number3);
}
 if (nLiczba.Contains<char>(number4))
{
    Console.WriteLine(number4);
}
 if (nLiczba.Contains<char>(number5))
{
    Console.WriteLine(number5);
}
 if (nLiczba.Contains<char>(number6))
{
    Console.WriteLine(number6);
}
 if (nLiczba.Contains<char>(number7))
{
   
    {
        Console.WriteLine(number7);
    }
}
 if (nLiczba.Contains<char>(number8))
{
    Console.WriteLine(number8);
}
 if (nLiczba.Contains<char>(number9))
{
    Console.WriteLine(number9);
}
if (nLiczba.Contains<char>(number10))
{
    Console.WriteLine(number10);
}
//Console.WriteLine( numer +"  Wtym numerze zawierają się te liczby");  // pokazuje liczbę 
Console.WriteLine(nLiczba.Length + "  Tyle jest char (Liczb)");  // liczy ile jest liczb (char)

// OPERATORY RELACYJNE 
// ==   równe
// <=  lub
// >=
// !=  są różne

// operator logiczny 
// && i 
// || lub 
// ! not - negacja