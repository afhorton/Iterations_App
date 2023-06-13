// See https://aka.ms/new-console-template for more information
// ask user how many numbers 
// collect the values, adding them up
// display the sum

int howMany;    // how many numbers to add
double number;  // the next input number
string input; // auxillary - to read user input
double sum = 0; // sum of the input

Console.WriteLine("How many numbers?");
input = Console.ReadLine();
howMany = Convert.ToInt32(input);

for (int i = 0; i < howMany; i++) // iterates howMany times - counter-based loop
{
    Console.WriteLine("Enter a number:");
    input = Console.ReadLine();
    number = Convert.ToDouble(input);
    sum += number; // sum = sum + number

}

//int i = 0;
//do
//{
//    Console.WriteLine("Enter a number:");
//    input = Console.ReadLine();
//    number = Convert.ToDouble(input);
//    sum += number; // sum = sum + number
//    i++;
//} while (i < howMany);

//int i = 0;
//while (i < howMany)
//{
//    Console.WriteLine("Enter a number:");
//   input = Console.ReadLine();
//    number = Convert.ToDouble(input);
//    sum += number; // sum = sum + number
//    i++;
//}

Console.WriteLine("\nThe sum is " + sum);
