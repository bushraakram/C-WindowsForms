using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order1
{
    public class Class1
    {
        public static string items;
        public static string price;
        public static string quantity;
        public static int number = 0;
        public static string[,] products = new string[3, 3];
        public static void Store(string i, string p, string q)
        {
            products[number, 0] = i;
            products[number, 1] = p;
            products[number, 2] = q;
            number++;
        }

        public static double calculate()
        {

            double[] arr = new Double[3];
            int x;
            double y;
            for (int i = 0; i < 3; i++)
            {
                y = Convert.ToDouble(products[i, 1]);
                x = Convert.ToInt32(products[i, 2]);
                arr[i] = x * y;
            }
            double sum = 0;
            for (int i = 0; i < 3; i++)
            {
                sum += arr[i];
            }
            return sum;
        }

        public static string[,] info()
        {
            return products;
        }

       
    }
}
