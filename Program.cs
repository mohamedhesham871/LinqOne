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
            // in stock mean >0 
            var productCostGreater3_00 = ProductList.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3);
            foreach (var unit in productCostGreater3_00)
            {
                Console.WriteLine(unit);
            }
            Console.WriteLine("-------------Another Solve--------");
            var productCostGreater3_00_V2= from p in ProductList
                                           where p.UnitsInStock > 0 && p.UnitPrice>3
                                           select p;
            foreach (var unit in productCostGreater3_00_V2)
            {
                Console.WriteLine(unit);
            }
            #endregion
        }
    }
}
