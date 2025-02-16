using System.ComponentModel.DataAnnotations;
using static LinqOne.ListGenerator;
namespace LinqOne
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            #region One :1. Find all products that are out of stock
            //var OutOfStock = ProductList.Where(p => p.UnitsInStock == 0);

            //foreach (var item in OutOfStock)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("------------Another Solve---------");

            //var OutOfStock02 =from p in ProductList
            //                  where p.UnitsInStock == 0
            //                  select p;
            //foreach (var item in OutOfStock02)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Two :2. Find all products that are in stock and cost more than 3.00 per unit.
            //// in stock mean >0 
            //var productCostGreater3_00 = ProductList.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3);
            //foreach (var unit in productCostGreater3_00)
            //{
            //    Console.WriteLine(unit);
            //}
            //Console.WriteLine("-------------Another Solve--------");
            //var productCostGreater3_00_V2= from p in ProductList
            //                               where p.UnitsInStock > 0 && p.UnitPrice>3
            //                               select p;
            //foreach (var unit in productCostGreater3_00_V2)
            //{
            //    Console.WriteLine(unit);
            //}
            #endregion

            #region Three :Returns digits whose name is shorter than their value.
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var List = Arr.Where((a, i) => a.Length < i);
            //foreach (var a in List)
            //{
            //    Console.WriteLine(a);
            //}
            #endregion

            //three Missing 

            #region [Part Two] One : 1. Return a sequence of just the names of a list of products.
            //var ProductName = ProductList.Select(p => p.ProductName);

            //foreach (var Product in ProductName)
            //{
            //    Console.WriteLine(Product);
            //}
            //Console.WriteLine("-------------Another Solve--------");
            //var ProductName02 = from p in ProductList
            //                    select p.ProductName;
            //foreach (var Product in ProductName02)
            //{
            //    Console.WriteLine(Product);
            //}
            #endregion

            #region  [Part Two] Two :Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).
            string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            var test =from c in words
                      select new { lower =c.ToLower() ,Upper =c.ToUpper() };
            foreach (var word in test)
            {
                Console.WriteLine(word);
            }

            #endregion

            #region [Part Two] Three: 3. Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.
            //var SeqOfProduct = ProductList.Select(p => new
            //{
            //    ID = p.ProductID,
            //    PName = p.ProductName,
            //    Category = p.Category,
            //    Price = p.UnitPrice,
            //    UnitsInStock = p.UnitsInStock
            //});
            //foreach (var item in SeqOfProduct)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 4. Determine if the value of ints in an array match their position in the array.

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var ISposition = Arr.Select((p, i) => i == p);

            //foreach (var i in ISposition)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region [Part two] 5 :Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.

            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };
            //var compare = from a in numbersA
            //              from b in numbersB
            //              where a.CompareTo(b) == -1
            //              select $"{a} is Less than {b}";

            //foreach (var i in compare)
            //{
            //    Console.WriteLine(i);
            //}
            //Please Help ME to make it Fluent not Query 
            #endregion

            #region [Part Two] 6 :6. Select all orders where the order total is less than 500.00.
            //var OrderLessThan500 = from i in CustomerList
            //                       from o in i.Orders
            //                       where o.Total < 500
            //                       select o;
            //foreach (var order in OrderLessThan500)
            //{
            //    Console.WriteLine(order);
            //}
            // Ask You Again Help ME  to make Fluent
            #endregion

            #region [Part Two] 7 :Select all orders where the order was made in 1998 or later.
            //var OrdersList = from i in CustomerList
            //                 from o in i.Orders
            //                 where o.OrderDate >= new DateTime(1998, 1, 1)
            //                 select o;
            //foreach (var o in OrdersList)
            //{
            //    Console.WriteLine(o);
            //}

            #endregion

        }
    }
}
