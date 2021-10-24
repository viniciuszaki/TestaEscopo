using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliquotaJoao
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = 3300.00;

            if (salario >= 1900.0 && salario <= 2800.0)
            {
                Console.WriteLine("Seu Salario é de " + salario);
                Console.WriteLine("O seu IR é de 7.5%");
                Console.WriteLine("Você pode deduzir R$ 142 na declaração");
            }

            if (salario >= 2800.01 && salario <= 3751.00)
            {
                Console.WriteLine("Seu Salario é de " + salario);
                Console.WriteLine("O seu IR é de 15%");
                Console.WriteLine("Você pode deduzir R$ 350 na declaração");
            }

            if (salario >= 3751.01 && salario <= 4664.00)
            {
                Console.WriteLine("Seu Salario é de " + salario);
                Console.WriteLine("O seu IR é de 22.5%");
                Console.WriteLine("Você pode deduzir R$ 636 na declaração");
            }

            Console.ReadLine();
        }
    }
}
