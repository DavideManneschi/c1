using System;
using static System.Convert;
using System.Net;
using ConsoleApplication1;

// it needs to be noted that the keyword static can be used in order to 


enum test_enum
{
    first,second_enum_value,third_ernum_value
    
    
    
}

public class test_public_class
{



    public void test_foreach()
    {



        // HttpClient client = new();


        int[] first_array = { 9, 0, 8, 09, 0 };

        foreach (int i in first_array)
        {
            Console.WriteLine("the current number of i is" + i);


        }

        {

        }

    }

    // it is possible to write statements also in the following way

    public void other_way()
    {
        double height = 67;

        // here is used to print the result of the element 
        Console.WriteLine($"the following variable is called{nameof(height)}");

    }

    public void get_result_different_types()
    {

        // in order  to utilize verbatim strings it must be doing the following 

        // in order to use verbatim string it must be used the following: @


        string Filepath = @"C:\televisions\sony\bravia.txt";

        // it is possible also o use raw string literals in the following way




        // the following way is used in order to store elements in different formats 

        int decimal_notation = 2_000;
        int binary_notation = 0b_0001;
        int hexadecimal_notation = 0x_11E;

        // comparing decimal types 

        //
        //
        // var is Used in order to declare a variable in an implicit manner


        //
        // int leght2 = ((String)name).Length;

        //dynamic string 

        // also in c # is prensent operator overloading 

        dynamic something = "amehed";






    }

    public void operating_variables()
    {


        int first_operand = 6;
        double second_operand = 7.9;



        // the following manner it is poossible to 
        // use also different types of variables in the following way 



        double test_one_variable = 7.98;
        Console.WriteLine($"the variable of the log is the following{test_one_variable:N1}");
        // whilew if we print it in a different format we can have the following result 
        Console.WriteLine($"the variable in quesyion in this case is{test_one_variable:e2}")

            ;





    }

    public void working_with_arrays()
    {


        String[,] first_grid = new[,]
        {

            { "Alpha", "Beta", "Gamma", "Delta" },
            { "Anne", "Ben", "Charlie", "Doug" },
            { "Aardvark", "Bear", "Cat", "Dog" }


        };

        // it is possible otherwise to do it in the following manner 

        String[,] second_multi_dimentional_string = new String[1, 2];

        // and then here we assign the variablews in the following 

        second_multi_dimentional_string[9, 8] = "AlPha";
        second_multi_dimentional_string[0, 9] = "uy";


        // it is possible to perform also operations with jagged arrays 


        // it is called jagged array





    }

    public void pattern_matching()
    {
        // it is possible to do a matching of the numbers 

        // lets create an array so it is possible 

        int[] array_1 = { 0, 9, 8 };
        int[] array_2 = { 0, 8, 7 };
        int[] array_3 = { 9, 0, 7, 0, 8 };

        // lets see some matching patterns rigHt now 


        /// it is possible to use different ways to declare arrays
        ///
        ///
        /// single dimnention array
        ///
        ///
        /// jagged array aka array with different values in each column
    }

    public void casting_values()
    {
        // it is possible to convert with the system.convert.type 


        double g = 9.8;

        int h = ToInt32(g); // this  is the way that  uses System.convert
        Console.WriteLine($" the first type is {g} while the second type is {h}");

        // it is possi9ble to take control of rounding  rules in the following way 


        // it is possible to take control of the rounding rules by using the round of the math class 




    }

    public void round_doubles()
    {


        // it is possible to round doubles in the following manner 


        double[] array_of_doubles = { 9.987, 8.544, 9.765, 9.645 };

        // now iterate 

        foreach (int i in array_of_doubles)
        {

           // Console.WriteLine(format:);

        }



    }

    // it is possible to avoid exceptions using the tryparse mnethod in the following way 


    public void try_parse()
    {


        try
        {
            Console.WriteLine("the following is the expression e");

            string input = Console.ReadLine();
            Console.WriteLine("the input written in the following  page is the following:" + " " + input);



            // this can be done also in the following manner 

            int count;

            bool res;
            int a;
            string myStr = "12";
            // this can be seen as another way to do the parsing method

            // it can be used as a sanityn check in order to chheck if it is actually possibleto do a type conversion 


            res = int.TryParse(myStr, out a);
            Console.WriteLine("String is a numeric representation: " + res);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }


    public void catch_expression()
        {
            
            // it is possible in this way to catch all or some specific expressions 
            
            
            
            
            
        }
        
    
    // aS a consequence it is possible to catch specific expressions by defing the tupe of exception occurred 
    
    // in the following way 


    public void catch_with_filters()
    {
        
        // it is possible also to catch with filters in c# in the following way 
        Console.WriteLine("please write the ammount of dollars that you want to input:");
        String amount = Console.ReadLine();

        try
        {

            double double_amount = double.Parse(amount);
            Console.WriteLine($"the writeline returns an amount in the following order:{double_amount:C}");

        }
        
        // this  gives more specificity to the  exception handling

        catch (FormatException)when (amount.Contains("$"))
        {
            Console.WriteLine("the amunt selected cannot contain the dollart sign!");
            
            
            
            
        }
    }

    }










namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            test_public_class first_class = new test_public_class();
            first_class.try_parse();
            
            
            
            Console.WriteLine("this is a test of a script");
            
        }
    }
}