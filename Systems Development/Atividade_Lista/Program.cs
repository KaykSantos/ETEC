using System;

namespace Exercicio_3
{
    class Program
    {
        public struct Carro
        {
            public string modelo, cor;
            public int ano, cd_Carro;
        }
        static void Main(string[] args)
        {
            //Declaração de variáveis
            Carro[] carros = new Carro[500];
            int menu = 0;
            int x = 0;
            
            //Preenchimento rápido básico
            for(x = 0; x < 500; x++){
                carros[x].modelo = "ModeloCarro";
                carros[x].cor = "CorCarro";
                carros[x].ano = 0;
                carros[x].cd_Carro = 0;
            }

            //Print do menu inicial
            Console.WriteLine(" [ 1 ] – Cadastrar carro\n\n [ 2 ] – Consultar carro por ano de fabricação\n\n [ 3 ] – Consultar carro por modelo\n\n [ 4 ] – Consultar carro por cor\n\n [ 5 ] – Exibir todos os carros cadastrados\n\n [ 6 ] – Alterar algum dado de um carro\n\n [ 7 ] – Excluir um carro\n\n [ 0 ] – Sair");
            
            Console.Write("Digite a opção: ");
            menu = int.Parse(Console.ReadLine());

            switch(menu){
                
                //CASO 1 ---> Cadastrar carro
                case 1:
                    string cont = "S"; //verificar se deseja continuar
                    int c1 = 0;
                    do{

                        Console.WriteLine("\nDigite as informações necessárias");

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
                        carros.cd_Carro++;
                        
                        Console.Write("Deseja continuar?[S/N]\nDigite aqui:");
                        cont = Console.ReadLine();

                    }while(cont == "S" || cont == "s"); // Enquanto for "S" continuara repetindo
                    c1 = 0;
                break;
                
                //CASO 2 --->  Consultar carro por ano de fabricação 
                //deverá listar todos os carros fabricados no ano digitado pelo usuário
                case 2:
                    int anoVer = 0;
                    Console.WriteLine("Digite o ano de fabricação do carro: ");
                    anoVer = int.Parse(Console.ReadLine());
                    int c2 = 0;
                    for(c2 = 0; c2 < 501; c2++){
                        if(carros[c2].ano == anoVer){
                            Console.WriteLine($"Carro {cd_Carro}\n Modelo: {carros[c2].modelo}\n Cor: {carros[c2].cor}\n Código do carro: {carros[c2].cd_Carro}\n-----------------");
                        }
                    }
                    anoVer = 0;
                    c2 = 0;
                break;

                //CASO 3 ---> Consultar carro por modelo 
                //deverá listar todos os carros cujo modelo será digitado pelo usuário
                case 3:
                    string modeloVer = "Modelo_Carro";
                    Console.WriteLine("Digite o modelo do carro: ");
                    modeloVer = Console.ReadLine();
                    int c3 = 0;
                    for(c3 = 0; c3 < 501; c3++){
                        if(carros[c3].modelo == modeloVer){
                            Console.WriteLine($"-----------------\nCarro {cd_Carro}\n Data de fabricação: {carros[c3].ano}\n Cor: {carros[c3].cor}\n Código do carro: {carros[c3].cd_Carro}\n-----------------");
                        }
                    }
                    modeloVer = "Modelo_Carro";
                    c3 = 0;
                break;

                //CASO 4 ---> Consultar carro por cor 
                //deverá listar todos os carros cuja cor será digitada pelo usuário 
                case 4:
                    string corVer = "Cor_Carro";
                    Console.WriteLine("Digite a cor do carro: ");
                    corVer = Console.ReadLine();
                    int c4 = 0;
                    for(c4 = 0; c4 < 501; c4++){
                        if(carros[c4].cor == corVer){
                            Console.WriteLine($"-----------------\nCarro {cd_Carro}\n Data de fabricação: {carros[c4].ano}\n Modelo: {carros[c4].modelo}\n Código do carro: {carros[c4].cd_Carro}\n-----------------");
                        }
                    }
                    corVer = "Cor_Carro";
                    c4 = 0;
                break;

                //CASO 5 ---> Exibir todos os carros cadastrados 
                case 5:
                    int c5 = 0;
                    for(c5 = 0; c5 < 501; c5++){
                        if(carros[c5].cd_Carro != 0 && carros[c5].cd_Carro > 0 && carros[c5].cd_Carro < 501){
                            Console.WriteLine($"-----------------\nCarro {cd_Carro}\n Data de fabricação: {carros[c5].ano}\n Modelo: {carros[c5].modelo}\n Cor: {carros[c5].cor}\n Código do carro: {carros[c5].cd_Carro}\n-----------------");                          
                        }
                    }
                    c5 = 0;
                break;

                //CASO 6 ---> Alterar algum dado de um carro 
                //deverá listar todos os dados de um determinado carro e solicitar que o usuário escolha qual campo deseja alterar
                case 6:
                    int cdCarroVer = 0, menuCar = 0, c6 = 0;
                    Console.WriteLine("Digite o código do carro: ");
                    cdCarroVer = int.Parse(Console.ReadLine());
                    
                    for(c6 = 0; c6 < 501; c++){
                        if(cdCarroVer == carros[c6].cd_Carro){
                            Console.Write("Alterar carro\n\n [ 1 ] Modelo\n\n [ 2 ] Cor\n\n [ 3 ] Data de Fabricação\n\n Digite a opção: ");
                            menuCar = int.Parse(Console.ReadLine());
                            switch(menuCar){

                            }
                        }
                    }
                    

                break;

                case 7:
                break;

                case 0:
                break;
                
                default:
                break;

            }

            Console.ReadKey();
        }
    }
}
