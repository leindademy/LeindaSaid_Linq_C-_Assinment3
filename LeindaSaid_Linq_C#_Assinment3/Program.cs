 using static LeindaSaid_Linq_C__Assinment3.ListGenerator;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace LeindaSaid_Linq_C__Assinment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ques_1
            /// 1. Get the first 3 orders from customers in Washington
            //var CustomerOrders = CustomerList.Select(CustomerData => new { CustomerData.City, CustomerData.Orders }).Where(City => City.City == "Washington").Take(3);
            //foreach (var item in CustomerOrders)
            //   {
            //       Console.WriteLine(item);
            //   }
            #endregion 

            #region Ques_2
            // 2. Get all but the first 2 orders from customers in Washington.
            // var CustomerOrders = CustomerList.Select(CustomerData => new { CustomerData.City, CustomerData.Orders }).Where(City => City.City == "Washington").Skip(2);
            //foreach (var item in CustomerOrders)
            //    {
            //        Console.WriteLine(item);
            //    }
            #endregion

            #region Ques_3 
            //3.Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.
            // int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var array = numbers.TakeWhile ((number, index) => number >= index);
            //foreach (var item in array)
            //    {
            //        Console.WriteLine(item);
            //    }
            #endregion

            #region Ques_4
            //4.Get the elements of the array starting from the first element divisible by 3.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var array = numbers.SkipWhile(number => number% 3 != 0);
            //foreach (var item in array)
            //    {
            //        Console.WriteLine(item);
            //    }
            #endregion

            #region Ques_5
            // 5. Get the elements of the array starting from the first element less than its position.
           // int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var array = numbers.TakeWhile((number, index) => number >= index);
            foreach (var item in array)
                {
                    Console.WriteLine(item);
                }
            #endregion
        }
    }
}
