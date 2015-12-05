namespace _02.InterestCalculator
{
    using System;

    public static class Validator
    {
        public static void ValidateNum(dynamic num, string type)
        {
            if (num < 0)
            {
                throw new ArgumentException($"{type} sould be positive");
            }
        }
    }
}