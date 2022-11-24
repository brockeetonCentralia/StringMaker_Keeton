//Broc Keeton
//IT113
//NOTES:
//BEHAVIORS NOT IMPLEMENTED AND WHY:

using StringMaker_Keeton;

StringManager output = new StringManager();

Console.WriteLine(output.Reverse("Sunbeam Tiger"));

Console.WriteLine(output._reverse("Sunbeam Tiger", false));

Console.WriteLine(output.Symmetric("ABBA"));

Console.WriteLine(output.Symmetric("ABA"));

Console.WriteLine(output.Symmetric("ABba"));

Console.WriteLine(output.ToString("Sunbeam Tiger"));

Console.WriteLine(output.Equals("Sunbeam Tiger"));
