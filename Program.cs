/******************************************************************************\
* Name: Jason D. F. D'Oyley
* Date: October 18, 2022
* Assignment CIS214 Week 3 GP - Methods, Statics, Class Math
*
* Main application (program) class.
* In this application we will demonstrate the creation and use of user-defined
* methods, static methods, method overloading, and the use of the Math Class.
\******************************************************************************/
public class StaticsMethodsMath
{
    // Static member variable - belongs to the App class
    private static string Label = "The maximum value is: ";

    static void Main(string[] args)
    {
        // Print a header line
        Console.WriteLine(
            "\nJason D'Oyley - Week 3 GP Methods, Statics, Class Math\n"
        );

        // Get 3 floating point values from the user
        Console.Write(
            "Enter 3 floating-point values separated by spaces: "
        );
        string? val = Console.ReadLine();

        // Check to make sure a value was entered before trying to use it
        if (!string.IsNullOrEmpty(val))
        {
            // Use the string.Split method to break the input string into an
            // array based on whitespace in the string
            string[] vals = val.Split();
            double f1 = double.Parse(vals[0]);
            double f2 = double.Parse(vals[1]);
            double f3 = double.Parse(vals[2]);

            Console.WriteLine($"{f1}\n{f2}\n{f3}");
        }
    }
}