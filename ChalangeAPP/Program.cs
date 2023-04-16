
int number = 8336;
string numer = number.ToString();
char[] nLiczba = numer.ToArray();

Console.WriteLine("Liczba " + numer + " posiada takie cyfry");

int counter0 = 0;
int counter1 = 0;
int counter2 = 0;
int counter3 = 0;
int counter4 = 0;
int counter5 = 0;
int counter6 = 0;
int counter7 = 0;
int counter8 = 0;
int counter9 = 0;

//  Liczym jakie mamy liczby i ile

foreach (var letter in nLiczba)
{
    if (letter == '0')
    {
        counter0++;
    }
    else if (letter == '1')
    {
        counter1++;
    }
    else if (letter == '2')
    {
        counter2++;
    }
    else if (letter == '3')
    {
        counter3++;
    }
    else if (letter == '4')
    {
        counter4++;
    }
    else if (letter == '5')
    {
        counter5++;
    }
    else if (letter == '6')
    {
        counter6++;
    }
    else if (letter == '7')
    {
        counter7++;
    }
    else if (letter == '8')
    {
        counter8++;
    }
    else if (letter == '9')
    {
        counter9++;
    }
}

//  Wypisujemy które liczby nam wystąpiły

Console.WriteLine("Liczb 0 => " + counter0);
Console.WriteLine("Liczb 1 => " + counter1);
Console.WriteLine("Liczb 2 => " + counter2);
Console.WriteLine("Liczb 3 => " + counter3);
Console.WriteLine("Liczb 4 => " + counter4);
Console.WriteLine("Liczb 5 => " + counter5);
Console.WriteLine("Liczb 6 => " + counter6);
Console.WriteLine("Liczb 7 => " + counter7);
Console.WriteLine("Liczb 8 => " + counter8);
Console.WriteLine("Liczb 9 => " + counter9);

// Liczymy ile cyfr jest w liczbie

Console.WriteLine(nLiczba.Count() + "  Ilość Liczb w Liczbie " + numer);


//  tworzenie tablicy Numery w celu sprawdzenia jakie cyfry zawiera nasza liczba

char[] numery = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

// Tu sprawdzamy jakie mamy cyfry

if (nLiczba.Contains<char>(numery[0]))
{
    Console.WriteLine("Mamy liczbę : " + numery[0]);
}
if (nLiczba.Contains<char>(numery[1]))
{
    Console.WriteLine("Mamy liczbę : " + numery[1]);
}
if (nLiczba.Contains<char>(numery[2]))
{
    Console.WriteLine("Mamy liczbę : " + numery[2]);
}
if (nLiczba.Contains<char>(numery[3]))
{
    Console.WriteLine("Mamy liczbę : " + numery[3]);
}
if (nLiczba.Contains<char>(numery[4]))
{
    Console.WriteLine("Mamy liczbę : " + numery[4]);
}
if (nLiczba.Contains<char>(numery[5]))
{
    Console.WriteLine("Mamy liczbę : " + numery[5]);
}
if (nLiczba.Contains<char>(numery[6]))
{
    Console.WriteLine("Mamy liczbę : " + numery[6]);
}
if (nLiczba.Contains<char>(numery[7]))
{
    Console.WriteLine("Mamy liczbę : " + numery[7]);
}
if (nLiczba.Contains<char>(numery[8]))
{
    Console.WriteLine("Mamy liczbę : " + numery[8]);
}
if (nLiczba.Contains<char>(numery[9]))
{
    Console.WriteLine("Mamy liczbę : " + numery[9]);
}