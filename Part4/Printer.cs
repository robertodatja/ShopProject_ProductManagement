namespace Part4
{
    public class Printer
    {
        //Kjo klase do t ekete disa metoda
        //Fillimisht do kete nje metode te thjeshte, ecila printon propertyt e cdo produkti dhe i formatojme si te duam.
        public void PrintToConsole(List<Product> products) 
        {
            for (int index = 0; index < products.Count; index++)
            {
                var product = products[index];
                Console.WriteLine("Product number {0}", index+1);
                Console.WriteLine("Name:          {0}", product.Name);
                //Console.WriteLine("Ordered:     {0}", product.OrderDate.ToString("F"));
                Console.WriteLine("Ordered:       {0:F}", product.OrderDate);
                Console.WriteLine("Amount:        {0}", product.Amount + (product.IsCountable ? "P" : "KG")); //P-Piece KG-Kilogram
                Console.WriteLine("Unit price:    {0:C}", product.Price); //c-dollar sign
                Console.WriteLine("Line total:    {0:C}", product.Price * product.Amount);
                Console.WriteLine("--------------------------------------------------");
            }
        }

    }
}
