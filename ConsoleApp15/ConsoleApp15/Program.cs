using System;

namespace ConsoleApp15
{
    public class Product
    {
        public int getMaxProduct(string input)
        {
            int maxProduct = 0;

            for (int i = 0; i < input.Length - 3; i++)
            {
                int tempProduct = 1;

                for (int j = 0; j < 4; j++)
                {
                    char k = input[i + j];
                    int val = (int)Char.GetNumericValue(k);
                    tempProduct = tempProduct * val;
                }

                if (tempProduct > maxProduct)
                {
                    maxProduct = tempProduct;
                }

            }

            return maxProduct;
        }

    }
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number  greater than 999 ");
            string input = Console.ReadLine();

            Product product = new Product();
            int maxProduct = product.getMaxProduct(input);

            Console.WriteLine($"maxProduct is : {maxProduct} ");
        }

    }
}