using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoFIM
{
    class Program
    {
        public struct Carro
        {
            public string modelo, cor;
            public int ano, cd_Carro;
        }
        public struct Verificacao
        {
            public bool sairPrincipal, sairC1, sairC2, sairC3, sairC4, sairC5, sairC6, sairC7;
        }
        static void Main(string[] args)
        {
            //Declaração de variáveis
            Carro[] carros = new Carro[500];
            Verificacao Ver;
            int menu = 0;
            int x = 0;
            Ver.sairPrincipal = false; Ver.sairC1 = false; Ver.sairC2 = false; Ver.sairC3 = false; Ver.sairC4 = false; Ver.sairC5 = false; Ver.sairC6 = false; Ver.sairC7 = false;
            int c1 = 0, c2 = 0, c3 = 0, c4 = 0, c5 = 0, c6 = 0, c7 = 0;
            string modeloVer = "Modelo_Carro";


            //Preenchimento rápido básico
            for (x = 0; x < 500; x++)
            {
                carros[x].modelo = "ModeloCarro";
                carros[x].cor = "CorCarro";
                carros[x].ano = 0;
                carros[x].cd_Carro = 0;
            }

            do // Repetição principal
            {
                //Print do menu inicial

                Console.WriteLine("\n [ 1 ] – Cadastrar carro\n\n [ 2 ] – Consultar carro por ano de fabricação\n\n [ 3 ] – Consultar carro por modelo\n\n [ 4 ] – Consultar carro por cor\n\n [ 5 ] – Exibir todos os carros cadastrados\n\n [ 6 ] – Alterar algum dado de um carro\n\n [ 7 ] – Excluir um carro\n\n [ 0 ] – Sair");
                Console.Write("\n Digite a opção: ");
                menu = int.Parse(Console.ReadLine());

                switch (menu)
                {

                    //CASO 0 ---> Sair
                    case 0:
                        if (menu == 0)
                        {
                            Ver.sairPrincipal = true;
                        }
                        Console.Clear();
                        Console.WriteLine("Saindo...\nAperte enter");
                        break;

                    //CASO 1 ---> Cadastrar carro
                    case 1:
                        string cont = "S"; //verificar se deseja continuar
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Digite as informações necessárias");

                            Console.Write("Digite o modelo do carro: ");
                            carros[c1].modelo = Console.ReadLine();
                            Console.Clear();

                            Console.Write("Digite a cor do carro: ");
                            carros[c1].cor = Console.ReadLine();
                            Console.Clear();

                            Console.Write("Digite o ano de fabricação do carro: ");
                            carros[c1].ano = int.Parse(Console.ReadLine());
                            c1++;

                            //Código do carro
                            carros[c1].cd_Carro = (carros[c1].cd_Carro + 1);

                            Console.Write("Deseja continuar?[S / N]\nDigite aqui:");
                            cont = Console.ReadLine();

                        } while (cont == "S" || cont == "s"); // Enquanto for "S" continuara repetindo
                        break;

                    //CASO 2 --->  Consultar carro por ano de fabricação 
                    //deverá listar todos os carros fabricados no ano digitado pelo usuário
                    case 2:
                        Console.Clear();
                        int anoVer = 0;
                        Console.Write("Digite o ano de fabricação do carro: ");
                        anoVer = int.Parse(Console.ReadLine());
                        for (c2 = 0; c2 < 500; c2++)
                        {
                            if (carros[c2].ano == anoVer)
                            {
                                Console.WriteLine($"Carro {(carros[c2].cd_Carro + 1)}\n Modelo: {carros[c2].modelo}\n Cor: {carros[c2].cor}\n Código do carro: {carros[c2].cd_Carro}\n-----------------");
                            }
                        }
                        anoVer = 0;
                        c2 = 0;
                        break;

                    //CASO 3 ---> Consultar carro por modelo 
                    //deverá listar todos os carros cujo modelo será digitado pelo usuário
                    case 3:
                        Console.Clear();
                        Console.Write("Digite o modelo do carro: ");
                        modeloVer = Console.ReadLine();
                        Console.Clear();


                        for (c3 = 0; c3 < 500; c3++)
                        {
                            if (carros[c3].modelo == modeloVer)
                            {
                                Console.WriteLine($"-----------------\nCarro {(carros[c3].cd_Carro)}\n Data de fabricação: {carros[c3].ano}\n Cor: {carros[c3].cor}\n Código do carro: {carros[c3].cd_Carro}\n-----------------");
                            }
                        }
                        modeloVer = "Modelo_Carro";
                        c3 = 0;
                        break;

                    //CASO 4 ---> Consultar carro por cor 
                    //deverá listar todos os carros cuja cor será digitada pelo usuário 
                    case 4:
                        string corVer = "Cor_Carro";
                        Console.Clear();
                        Console.Write("Digite a cor do carro: ");
                        corVer = Console.ReadLine();
                        for (c4 = 0; c4 < 500; c4++)
                        {
                            if (carros[c4].cor == corVer)
                            {
                                Console.WriteLine($"-----------------\nCarro {(carros[c4].cd_Carro)}\n Data de fabricação: {carros[c4].ano}\n Modelo: {carros[c4].modelo}\n Código do carro: {carros[c4].cd_Carro}\n-----------------");
                            }
                        }
                        corVer = "Cor_Carro";
                        c4 = 0;
                        break;

                    //CASO 5 ---> Exibir todos os carros cadastrados 
                    case 5:
                        Console.Clear();
                        for (c5 = 0; c5 < 500; c5++)
                        {
                            if (carros[c5].cd_Carro != 0 && carros[c5].cd_Carro > 0 && carros[c5].cd_Carro < 501)
                            {
                                Console.WriteLine($"-----------------\nCarro {carros[c5].cd_Carro}\n Data de fabricação: {carros[c5].ano}\n Modelo: {carros[c5].modelo}\n Cor: {carros[c5].cor}\n Código do carro: {carros[c5].cd_Carro}\n-----------------");
                            }
                        }
                        c5 = 0;
                        break;

                    //CASO 6 ---> Alterar algum dado de um carro 
                    //deverá listar todos os dados de um determinado carro e solicitar que o usuário escolha qual campo deseja alterar
                    case 6:
                        int cdCarroVer1 = 0, menuCar1 = 0;
                        Console.Write("Digite o código do carro: ");
                        cdCarroVer1 = int.Parse(Console.ReadLine());

                        for (c6 = 0; c6 < 500; c6++)
                        {
                            if (cdCarroVer1 == carros[c6].cd_Carro)
                            {
                                Console.Write("Alterar carro\n\n [ 1 ] Modelo\n\n [ 2 ] Cor\n\n [ 3 ] Data de Fabricação\n\n Digite a opção: ");
                                menuCar1 = int.Parse(Console.ReadLine());
                                switch (menuCar1)
                                {
                                    //EDITAR MODELO
                                    case 1:
                                        Console.Write("Digite o modelo do carro: ");
                                        carros[c6].modelo = Console.ReadLine();
                                        break;

                                    //EDITAR COR
                                    case 2:
                                        Console.Write("Digite a cor do carro: ");
                                        carros[c6].cor = Console.ReadLine();
                                        break;

                                    //EDITAR DATA DE FABRICAÇÃO
                                    case 3:
                                        Console.Write("Digite o modelo do carro: ");
                                        carros[c6].ano = int.Parse(Console.ReadLine());
                                        break;

                                    default:
                                        Console.Write("Opção Inválida");
                                        break;
                                }
                            }
                        }
                        cdCarroVer1 = 0;
                        c6 = 0;
                        menuCar1 = 0;
                        break;

                    //CASO 7 ---> Excluir um carro
                    //(deverá listar todos os dados de um determinado carro e solicitar a confirmação para exclusão)
                    case 7:
                        int cdCarroVer2 = 0;
                        Console.WriteLine("Digite o código do carro: ");
                        cdCarroVer2 = int.Parse(Console.ReadLine());
                        for (c7 = 0; c7 < 500; c7++)
                        {
                            if (cdCarroVer2 == carros[c7].cd_Carro)
                            {
                                string apagar1 = "S";
                                Console.Write("Deseja realmente apagar o carro? [S / N]");
                                apagar1 = Console.ReadLine();
                                if (apagar1 == "S" || apagar1 == "s")
                                {
                                    carros[c7].modelo = "ModeloCarro";
                                    carros[c7].cor = "CorCarro";
                                    carros[c7].ano = 0;
                                    carros[c7].cd_Carro = 0;
                                }
                            }
                        }
                        cdCarroVer2 = 0;
                        break;

                    default:
                        Console.Write("Opção Inválida");
                        break;

                }

            } while (Ver.sairPrincipal == false);
            Console.ReadKey();
        }
    }
}