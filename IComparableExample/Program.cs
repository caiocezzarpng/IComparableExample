using IComparableExample.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparableExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"funcionarios.csv";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Employee> employees = new List<Employee> ();
                    while (!sr.EndOfStream) 
                    {
                        employees.Add(new Employee(sr.ReadLine()));
                    }

                    employees.Sort();

                    foreach (Employee emp in employees)
                    {
                        Console.WriteLine(emp);
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
