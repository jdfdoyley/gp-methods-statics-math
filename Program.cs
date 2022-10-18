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

            // Find the maximum of the 3 values and print the result
            DisplayMessage(MaxOfThree(f1, f2, f3));
        }

        // Get 3 integer values from the user
        Console.Write(
            "\nEnter 3 integer values separated by spaces: "
        );
        val = Console.ReadLine();

        if (!string.IsNullOrEmpty(val))
        {
            string[] vals = val.Split();
            int i1 = int.Parse(vals[0]);
            int i2 = int.Parse(vals[1]);
            int i3 = int.Parse(vals[2]);

            // Find the maximum of the 3 values and print the result
            DisplayMessage(MaxOfThree(i1, i2, i3));
        }
    }

    // Static method to display a message with a floating-point value
    public static void DisplayMessage(double val)
    {
        Console.WriteLine("{0}{1:F2}", Label, val);
    }

    // Overloaded version of the static method allowing display of a message
    // with an integer value
    public static void DisplayMessage(int val)
    {
        Console.WriteLine("{0}{1}", Label, val);
    }

    // Static method to find the maximum of 3 floating-point numbers
    public static double MaxOfThree(double x, double y, double z)
    {
        // Use the Math class' "max" method to find the max value of the first
        // two values and store it in a local variable
        double maximumValue = Math.Max(x, y);

        // Use the max method to find the max between our max variable and the
        // final value, and return the result
        return Math.Max(maximumValue, z);
    }

    // Overload version of the static method providing the ability to find the
    // maximum of 3 integer numbers. Note that the processing is identical to
    // to the floating-point version and even uses the "max" method...which is
    // possible because Math.max is an overloaded method itself
    public static int MaxOfThree(int x, int y, int z)
    {
        // Use the Math class' "max" method to find the max value of the first
        // two values and store it in a local variable
        int maximumValue = Math.Max(x, y);

        // Use the max method to find the max between our max variable and the
        // final value, and return the result
        return Math.Max(maximumValue, z);
    }
}