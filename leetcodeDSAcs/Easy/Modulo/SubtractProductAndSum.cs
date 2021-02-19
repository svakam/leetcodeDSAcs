using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodeDSAcs.Easy.Modulo
{
    // runtime: 32 ms, 99.01% faster
    // space: 14.9 mb, 99.01% less
    class SubtractProductAndSum
    {
        public int GetSPS(int n)
        {
            // get the product, get the sum, and return the result of the subtraction of the sum from the product
            return CreateSumOrProduct(n, TypeOfNumber.Product) - CreateSumOrProduct(n, TypeOfNumber.Sum);
        }

        // create product or sum depending on enum provided
        // modulo the input until all digits retrieved and used as a sum or product onto the resultant itself (don't need linked list if just going to use resultant itself)
        // return the sum or product
        public int CreateSumOrProduct(int n, TypeOfNumber m)
        {
            int result;
            switch (m)
            {
                case TypeOfNumber.Sum:
                    result = 0; // for some reason, variable can be initialized here and still in scope for the next case; but would be best practice to declare outside switch
                    while (n != 0)
                    {
                        result += n % 10;
                        n /= 10;
                    }
                    return result;
                case TypeOfNumber.Product:
                    result = 1;
                    while (n != 0)
                    {
                        result *= n % 10;
                        n /= 10;
                    }
                    return result;
                default:
                    return 0;
            }
        }
    }

    enum TypeOfNumber
    {
        Product,
        Sum
    }
}
