using static LinqOne.ListGenerator;
namespace LinqOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region One :1. Find all products that are out of stock
            var OutOfStock = ProductList.Where(p => p.UnitsInStock == 0);

            foreach (var item in OutOfStock)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------Another Solve---------");

            var OutOfStock02 =from p in ProductList
                              where p.UnitsInStock == 0
                              select p;
            foreach (var item in OutOfStock02)
            {
                Console.WriteLine(item);
            }
            //--
            #endregion
        }
    }
}
