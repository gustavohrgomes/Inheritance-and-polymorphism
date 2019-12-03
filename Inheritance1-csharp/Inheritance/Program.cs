using System;
using Inheritance.Entities;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount account = new BusinessAccount(905, "John doe", 200.0, 700.0);

            Console.WriteLine(account.Balance);

            // account.Balance = 300.00;
        }
    }
}
