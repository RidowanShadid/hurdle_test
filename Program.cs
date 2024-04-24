using System.Transactions;

namespace HurdleTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Sales sales = new Sales();

            Batch compSciBooks = new Batch("2024x00001", "CompSci Books");
            compSciBooks.Add(new Transaction("1", "Deep Learning in Python", 67.90m));
            compSciBooks.Add(new Transaction("2", "C# in Action", 54.10m));
            compSciBooks.Add(new Transaction("3", "Design Patterns", 129.75m));

            Batch nestedBatch = new Batch("2024x00003", "Nested Batch");
            nestedBatch.Add(new Transaction("00-0001", "Compilers", 134.60m));
            compSciBooks.Add(nestedBatch); // Adding nested batch to compSciBooks

            Batch emptyBatch = new Batch("2024x00002", "Empty Batch");
            // No transactions are added to demonstrate an empty batch

            Transaction singleOrder = new Transaction("10-0003", "Hunger Games 1-3", 45.00m);

            sales.Add(compSciBooks); // Add batch orders to Sales
            sales.Add(emptyBatch);   // Add an empty batch order to Sales
            sales.Add(singleOrder);  // Add single transaction orders to Sales

            sales.PrintOrders(); // Print all orders
        }
    }


}
