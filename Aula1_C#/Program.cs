using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividades_Cisne
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int i_nro1 = 0;
            int i_nro2 = 0;

            Console.WriteLine("Atividade 1\n");
            Console.Write("Digite o 1º numero inteiro: ");
            i_nro1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o 2º numero inteiro: ");
            i_nro2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Soma: {0}", i_nro1 + i_nro2);
            Console.ReadLine();


            double d_nro1 = 0;

            Console.WriteLine("Atividade 2\n");
            Console.Write("Digite um numero: ");
            d_nro1 = double.Parse(Console.ReadLine());

            Console.WriteLine("A terça parte do numero {0} é {1}", d_nro1, d_nro1 / 3);
            Console.ReadLine();

           


            d_nro1 = 0 ;
            double d_nro2 = 0 ;

            Console.WriteLine("Atividade 3\n");
            Console.Write("Digite um numero: ");
            d_nro1 = double.Parse(Console.ReadLine());
            Console.Write("Digite um numero: ");
            d_nro2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Média:  {0} ",(d_nro1 + d_nro2) / 2 );
            Console.ReadLine();
            
            double d_sal = 0;
            Console.WriteLine("Atividade 4\n");
            Console.Write("Digite o saldo R$: ");
            d_sal = double.Parse(Console.ReadLine());
            Console.WriteLine("Saldo:  {0:c} ",  d_sal * 1.01);
            Console.ReadLine();
            
            


          
            double n_prova1 = 0;
            double n_prova2 = 0;
            double n_prova3 = 0;
            double n_prova4 = 0;

            Console.WriteLine("Atividade 5\n");
            Console.Write("Digite a nota: ");
           n_prova1 = double.Parse(Console.ReadLine());
            Console.Write("Digite a nota: ");
            n_prova2 = double.Parse(Console.ReadLine());
            Console.Write("Digite a nota: ");
            n_prova3 = double.Parse(Console.ReadLine());
            Console.Write("Digite a nota: ");
            n_prova4 = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Média Final:  {0} ", (n_prova1 + n_prova2 + n_prova3 + n_prova4) / 4);
            Console.ReadLine();









        }
    }
}
