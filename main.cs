using System;
using System.Collections.Generic;

class Program {
  static Servico servico = new Servico();
  static Random random = new Random();
  static string escolha = "";
  static public List<PrestadordeServico> prestadorEscolhidos = new List<PrestadordeServico>();
  public static void Main (string[] args) {
    servico.PopulaPrestadorServico();
    
    var option = MenuInicial();
    switch (option)
    {
      case "1":
          CadastraUsuário();
          MenuPrincipal();
          break;

      case "2":
          MenuPrincipal();
          break;

      default:
          break;
    }

  }
  public static string MenuInicial()
        {
            Console.WriteLine("===== Service Fix =====");
            Console.WriteLine("Digite uma das opções abaixo para navegar:");

            Console.WriteLine("1 - Cadastrar Usuário.");
            Console.WriteLine("2 - Somente entrar");
            Console.WriteLine("3 - Sair.");

            var option = Console.ReadLine();

            return option;
        }

        public static void CadastraUsuário()
        {
            Console.WriteLine("Digite os seus dados abaixo:");

            Console.WriteLine("Digite seu nome:");
            var nome = Console.ReadLine();

            Console.WriteLine("Digite seu telefone:");
            string telefone = Console.ReadLine(); 

            Console.WriteLine("Digite sua Data de Nascimento:");
            var dataNascimento = Console.ReadLine();

            Console.WriteLine("Digite seu endereco:");
            var endereco = Console.ReadLine();

            Usuario usuario = new(nome, telefone, dataNascimento, endereco);

            Console.WriteLine("Cadastro efetuado com sucesso!");
        }

        public static void MenuPrincipal()
        {
            Console.WriteLine("=====Menu Principal=====");
            Console.WriteLine("1 - Pesquisar por categorias.");
            Console.WriteLine("2 - Sair.");

            var optionMenu = Console.ReadLine();

            switch (optionMenu)
            {
                case "1":
                    Console.WriteLine("Digite a categoria a ser contratada.");
                    Console.WriteLine("1 - Limpeza de Caixa D'Agua.");
                    Console.WriteLine("2 - Restauração de Móveis.");
                    Console.WriteLine("3 - Limpeza de Piscina");
                    Console.WriteLine("4 - Jardineiro");

                    var optionMenuCategorias = Console.ReadLine();

                    switch (optionMenuCategorias)
                    {
                        case "1":
                            escolha = "Limpeza de Caixa D'Agua";
                            break;

                        case "2":
                            escolha = "Restauração de Móveis.";
                            break;

                        case "3":
                            escolha = "Limpeza de Piscina";
                            break;

                        case "4":
                            escolha = "Jardineiro";
                            break;
                    }

                    for (int i = 0; i < servico.prestadordeServicos.Count; i++)
                    {
                        if (servico.prestadordeServicos[i].CategoriaServico == escolha)
                        {
                            prestadorEscolhidos.Add(servico.prestadordeServicos[i]);
                        }
                    }

                    Console.WriteLine($"Categoria escolhida: {escolha}");
                    Console.WriteLine("Escolha a empresa que deseja contratar");
                    Console.WriteLine($"0 - {prestadorEscolhidos[0].NomeEmpresa} - {prestadorEscolhidos[0].PrazoExecucaoServico} - R$ {random.Next(prestadorEscolhidos[0].ValorInicialServico, prestadorEscolhidos[0].ValorFinalServico)}");
                    Console.WriteLine($"1 - {prestadorEscolhidos[1].NomeEmpresa} - {prestadorEscolhidos[1].PrazoExecucaoServico} - R$ {random.Next(prestadorEscolhidos[1].ValorInicialServico, prestadorEscolhidos[1].ValorFinalServico)}");
                    var empresaEscolhida = Console.ReadLine();

                    Console.WriteLine("Serviço contratado com sucesso!");
                    Console.WriteLine("Abaixo a empresa escolhida:");
                    Console.WriteLine($"{prestadorEscolhidos[Convert.ToInt32(empresaEscolhida)].NomeEmpresa} - {prestadorEscolhidos[Convert.ToInt32(empresaEscolhida)].PrazoExecucaoServico} - R$ {random.Next(prestadorEscolhidos[Convert.ToInt32(empresaEscolhida)].ValorInicialServico, prestadorEscolhidos[Convert.ToInt32(empresaEscolhida)].ValorFinalServico)}");
                    
                    break;
            }
        }

    }
