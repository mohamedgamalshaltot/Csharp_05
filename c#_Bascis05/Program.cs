using System.Runtime.Intrinsics.X86;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace c__Bascis05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 01
            //1-Create a one-dimensional array double[] prices with the values 25.5, 40.0, 33.75. Print
            //the second price(index 1).
            double[] prices = { 25.5, 40.0, 33.75 };
            Console.WriteLine(prices[1]);

            #endregion
            #region Question 02
            //2-Create a 2x2 multidimensional array int[,] shelfCopies where shelf 0 has 3, 5 copies and
            //shelf 1 has 1, 4 copies.Print the number of copies on shelf 1, slot 0.
            int[,] shelfCopies = {
                { 3, 5 }, { 1, 4 }
            };
            Console.WriteLine(shelfCopies[1, 0]);


            #endregion
            #region Question 03
            //3-Write a method called PrintWelcomeMessage that takes no parameters and prints
            //"Welcome to the Library!".Call it from Main.
            {
                PrintWelcomeMessage();
            }

            #endregion
            #region Question 04
            //4-Write a method PrintBookTitle(string title) that prints "Book title: " + title. Call it with
            //"Clean Code".
            {
                PrintBookTitle("Clean Code");
            }

            #endregion
            #region Question 05
            //5-Write a method AddBonusPages(int pages) that adds 50 to pages. Call it with a variable
            //int pages = 400; and print pages afterward. What do you expect to see, and why?
            int pages = 400;
            AddBonusPages(pages);
            Console.WriteLine(pages);
            #endregion
            #region Question 06
             //6-Write a method ApplyDiscount(double[] prices) that subtracts 5 from prices[0]. Call it
            // with double[] prices = { 25.5, 40.0 }; and print prices[0] afterward.What do you expect to
            //see, and why?
            double[] prices2 = [ 25.5, 40.0 ];
            ApplyDiscount(prices2);
            Console.WriteLine(prices2[0]);
            //(why)لان ال شققشغ هنا بتمر لby reference typeهذا يعني ان ال Method تعدل مباشره في البيانات الموجودخ داخل المصفوفه في الذاكره.

            #endregion
            #region Question 07
              //7-Rewrite the method from question 5 as AddBonusPagesByRef(ref int pages) using ref.
             //Call it and print pages afterward. How is the result different from question 5 ?
             int pages2 = 400;
            AddBonusPagesByRef(ref pages2);
            Console.WriteLine(pages2);

            #endregion
        }
        #region Methods Area 
        //Question 03 Method
        static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Library!");
        }
        #endregion

        //Question 04 Method
        static void PrintBookTitle(string title)
        {
            Console.WriteLine("Book title: " + title);
        }

        //Question 05 Method
        static void AddBonusPages(int pages)
        {
            pages += 50;
        }
        //Question 06 Method
        static void ApplyDiscount(double[] prices)
        {
            prices[0] -= 5;
        }
        //Question 07 Method
        static void AddBonusPagesByRef(ref int pages)
        {
            pages += 50;
        }

    }
}
