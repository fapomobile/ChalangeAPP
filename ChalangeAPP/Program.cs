// See https://aka.ms/new-console-template for more informatio
// OPERATORY RELACYJNE 
// ==   równe
// >=
// !=  są różne

// operator logiczny 
// && i 
// || lub 
// ! not - negacja
int[] grades = new int[365];
List<string> dayOfWeeks = new List<string>();
dayOfWeeks.Add("poniedziałek");
dayOfWeeks.Add("wtorek");
dayOfWeeks.Add("środa");
dayOfWeeks.Add("czwartek");
dayOfWeeks.Add("piątek");
dayOfWeeks.Add("sobota");
dayOfWeeks.Add("niedziela");

foreach (var day in dayOfWeeks)
{
    Console.WriteLine(day);
}

//for(var i=0; i<dayOfWeeks.Count; i++)  // sposób na pewność że nie pomylimy się w ilości 
//{
//    Console.WriteLine(dayOfWeeks[i]);
//}

//Console.WriteLine(dayOfWeeks[2]);

//string[] dayOfWeeks2 = { "poniedziałek", "wtorek", "środa", "czwartek", "piątek", "sobota", "niedziela" };
//Console.WriteLine(dayOfWeeks2[5]);
Console.ReadLine();