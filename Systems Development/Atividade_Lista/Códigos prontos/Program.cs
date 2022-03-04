using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_1
{
    class Program
    {
        public struct Data
        {
            public int dia, mes, ano; 
        }
        public struct Verificacao
        {
            //"ano" é uma váriavel sobre o ano bissexto
            public bool ano, Ver; 
        }
        static void Main(string[] args)
        {
            //Declaração das variáveis
            Data data;
            Verificacao veriData; 
            veriData.ano = false;
            veriData.Ver = true;

            //Solicitação da data - Dia, Mês e Ano 
            Console.WriteLine("Digite uma data contendo dia, mês e ano (dd/mm/aaaa)");
            Console.Write("Dia: ");
            data.dia = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.Write("Mês: ");
            data.mes = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.Write("Ano: ");
            data.ano = int.Parse(Console.ReadLine());
            Console.Clear();

            //VERIFICACAO INICIAL ---> Dia, Mês e Ano (Maior e menor que) 
            if (data.dia > 31 || data.dia < 1 || data.mes > 12 || data.mes < 1 || data.ano > 2022)
            {
                veriData.Ver = false;
                Console.Clear();
                Console.WriteLine("Data inválida");
            }

            //VERIFICAÇÃO ---> Ano bissexto
            if (data.ano % 4 == 0 && data.ano % 100 != 0 || data.ano % 400 == 0)
            {
                veriData.ano = true;
            }

            //VERIFICAÇÂO ---> Fevereiro e ano bissexto
            if(data.dia >= 29 && veriData.ano == false)
            {
                veriData.Ver = false;
                Console.Clear();
                Console.WriteLine("Data inválida");
                
            }

            //VERIFICAÇÃO ---> Meses com 30 dias
            if(data.mes == 04 && data.dia > 30 || data.mes == 06 && data.dia > 30 || data.mes == 09 && data.dia > 30 || data.mes == 11 && data.dia > 30)
            {
                veriData.Ver = false;
                Console.Clear();
                Console.WriteLine("Data inválida");
            }
            
            if(veriData.Ver == true){
                Console.WriteLine($"A data inserida é válida (Data inserida: {data.dia}/{data.mes}/{data.ano})");
            }
            

            Console.ReadKey();
        }
    }
}
