using System;
using System.Collections.Generic;
using PolimorfismoAbstrato.Entities;
using System.Globalization;

namespace PolimorfismoAbstrato
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                if (ch == 'i')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Anual income: ");
                    double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Health expenditures: ");
                    double healthExpeditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(name, anualIncome, healthExpeditures));
                }
                if (ch == 'c')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Anual income: ");
                    double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, anualIncome, numberOfEmployees));
                }
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID: ");
            foreach (TaxPayer tp in list)
            {
                Console.WriteLine(tp.Name + " $ " + tp.Tax().ToString("F2", CultureInfo.InvariantCulture));
            }
            Console.WriteLine();
            Console.Write("TOTAL TAXES: ");
            double sum = 0.00;
            foreach (TaxPayer x in list)
            {
                sum += x.Tax();
            }
            Console.WriteLine(sum);
        }
    }
}
