
namespace oppgave1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Store Management System ===");
        
        // 1. Create a new product instance using 'new'
        Product myItem = new Product("Laptop", 120, 5000.0);

        // 2. Logic to determine discount based on the product's Stock
        double discountRate;

        if (myItem.Stock >= 100)
        {
            discountRate = 0.5; // 50% off
        }
        else if (myItem.Stock >= 50)
        {
            discountRate = 0.3; // 30% off
        }
        else
        {
            discountRate = 0;
        }

        // 3. Calculate final price
        double finalPrice = myItem.Price * (1 - discountRate);

        // 4. Output the details
        Console.WriteLine($"Product: {myItem.Name}");
        Console.WriteLine($"Original Price: {myItem.Price} NOK");
        Console.WriteLine($"Current Stock: {myItem.Stock}");
        Console.WriteLine($"Applied Discount: {discountRate * 100}%");
        Console.WriteLine($"-------------------------------");
        Console.WriteLine($"Final Price for {myItem.Name}: {finalPrice} NOK");
    }
}

/* no object eidtion
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Inventory Discount Calculator ===");
        Console.Write("Enter the current stock quantity: ");

        string input = Console.ReadLine()!;

        // Validate if input is a valid integer
        //Try converting the input (string) to an int (integer). 
        // If successful, store the result in the stock variable;
        //  if it fails, do not crash the program.
        if (int.TryParse(input, out int stock))
        {
            double discount = 0;
            string advice = "";

            // Assignment requirement: If/Else If/Else block
            if (stock >= 100)
            {
                discount = 0.5; // 50% discount
                advice = "Stock is very high. Applied Clearance Discount: 50% off.";
            }
            else if (stock >= 50)
            {
                discount = 0.3; // 30% discount
                advice = "Stock is high. Applied Seasonal Discount: 30% off.";
            }
            else if (stock >= 10)
            {
                discount = 0.1; // 10% discount
                advice = "Stock is normal. Applied Standard Discount: 10% off.";
            }
            else if (stock >= 0)
            {
                discount = 0;
                advice = "Stock is low. No discount applied.";
            }
            else
            {
                Console.WriteLine("Error: Stock cannot be negative.");
                return;
            }

            // Output results
            Console.WriteLine("--------------------------------------");
            Console.WriteLine($"Stock Level: {stock}");
            Console.WriteLine($"Status: {advice}");
            
            if (discount > 0)
            {
                Console.WriteLine($"Final Price: {(1 - discount) * 100}% of original price.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input! Please enter a whole number.");
        }
    }
}
*/
