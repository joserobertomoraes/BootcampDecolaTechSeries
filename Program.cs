using System;

namespace ProjetoDecolaSeries
{
    class Program
    {
		
		 static FilmeRepositorio repositorioFilme = new FilmeRepositorio();
        static SerieRepositorio repositorio = new SerieRepositorio();
        static void Main(string[] args)
        {
            
           string opcaoUsuario = ObterOpcaoUsuario();
while (opcaoUsuario != "9")
			{
				switch (opcaoUsuario)
				{
					

					case "1":
						Console.WriteLine(" Deseja inserir um novo: ");
					int escolha1 = ObterEscolha();
					if(escolha1 == 1){
						InserirFilme();
					}else
					{
						InserirSerie();
					}
						break;
					case "2":
					Console.WriteLine("Deseja listar um(a): ");
					int escolha2 = ObterEscolha();
						if(escolha2 == 1){
						ListarFilmes();
					}else
					{
						ListarSeries();
					}
						break;
					case "3":
					Console.WriteLine("Deseja Atualizar um(a): ");
					int escolha3 = ObterEscolha();
					if(escolha3 == 1){
						AtualizarFilme();
					}else
					{
						AtualizarSerie();
					};
						break;
					case "4":
						Console.WriteLine("Deseja Excluir um(a): ");
						int escolha4 = ObterEscolha();
					if(escolha4 == 1){
						ExcluirFilme();
					}else
					{
						ExcluirSerie();
					}
						break;
					case "5":
						Console.WriteLine("Deseja adicionar aos favoritos um(a): ");
					int escolha5 = ObterEscolha();
					if(escolha5 == 1){
						FavoritarFilmes();
					}else
					{
						FavoritarSeries();
					}
						break;
					case "6":
						Console.WriteLine("Deseja Visualizar um(a): ");
						int escolha6 = ObterEscolha();
					if(escolha6 == 1){
						VisualizarFilme();
					}else
					{
						VisualizarSerie();
					}
						break;
					case "7":
						Console.WriteLine("Deseja ver Relatorio de todos cadastrado de um(a): ");
					int escolha7 = ObterEscolha();
					if(escolha7 == 1){
						RelatoriodeFilme();
					}else
					{
						RelatoriodeSerie();
					}
					break;
                    case "8":
                        Console.Clear();
                        break;
				

					default:
						throw new ArgumentOutOfRangeException();
				}

				opcaoUsuario = ObterOpcaoUsuario();
			}

			Console.WriteLine("Obrigado por utilizar nossa Plataforma.");
			Console.ReadLine();


        } 
		private static void RelatoriodeFilme()
		{
			Console.WriteLine("Relatório de Filme cadastrada: ");
			Console.WriteLine();
			repositorioFilme.Mostratodos();
		}
private static void RelatoriodeSerie()
		{
			Console.WriteLine("Relatório de Series cadastrada: ");
			Console.WriteLine();
			repositorio.Mostratodos();
		}
		private static void VisualizarFilme()
		{
			Console.Write("Digite o id da série: ");
			int indiceFilme = int.Parse(Console.ReadLine());

			var filme = repositorioFilme.RetornaPorId(indiceFilme);

			Console.WriteLine(filme);
		}


		private static void VisualizarSerie()
		{
			Console.Write("Digite o id da série: ");
			int indiceSerie = int.Parse(Console.ReadLine());

			var serie = repositorio.RetornaPorId(indiceSerie);

			Console.WriteLine(serie);
		}
		private static void FavoritarFilmes()
		{
			Console.Write("Digite o id da série: ");
			int indiceFilme = int.Parse(Console.ReadLine());

			repositorioFilme.Favorita(indiceFilme);
		}
		private static void FavoritarSeries()
		{
			Console.Write("Digite o id da série: ");
			int indiceSerie = int.Parse(Console.ReadLine());

			repositorio.Favorita(indiceSerie);
		}
 		private static void ExcluirFilme()
		{
			Console.Write("Digite o id da série: ");
			int indiceFilme = int.Parse(Console.ReadLine());

			repositorioFilme.Exclui(indiceFilme);
		}
		 private static void ExcluirSerie()
		{
			Console.Write("Digite o id da série: ");
			int indiceSerie = int.Parse(Console.ReadLine());

			repositorio.Exclui(indiceSerie);
		}
		private static void AtualizarFilme()
		{
			Console.Write("Digite o id do Filme: ");
			int indiceFilme = int.Parse(Console.ReadLine());
		Console.Write("Digite o Título do Filme: ");
			string entradaTitulo = Console.ReadLine();

            Console.Write("Digite a Descrição do Filme: ");
			string entradaDescricao = Console.ReadLine();

			foreach (int i in Enum.GetValues(typeof(Genero)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
			}
			Console.Write("Digite o gênero entre as opções acima: ");
			int entradaGenero = int.Parse(Console.ReadLine());
			Console.Write("Digite o tempo do filme(Min): ");
			int entradaDuracao = int.Parse(Console.ReadLine());
           
            Console.Write("Digite a Classificacao do filme: ");
			int entradaClassificacao = int.Parse(Console.ReadLine());

			Console.Write("Digite o Ano de Lançamento do Filme: ");
			int entradaAno = int.Parse(Console.ReadLine());

			Console.Write("Digite o elenco do Filme ");
			string entradaElenco = Console.ReadLine();

			Filme AtualizarFilme = new Filme(id: indiceFilme,
            							titulo: entradaTitulo,
                                        descricao: entradaDescricao,
										genero: (Genero)entradaGenero,
										duracao: entradaDuracao,
                                        classificacao: entradaClassificacao,
										ano: entradaAno,
										elenco: entradaElenco);

			repositorioFilme.Atualiza(indiceFilme, AtualizarFilme);
		}
 private static void AtualizarSerie()
		{
			Console.Write("Digite o id da série: ");
			int indiceSerie = int.Parse(Console.ReadLine());
		Console.Write("Digite o Título da Série: ");
			string entradaTitulo = Console.ReadLine();

            Console.Write("Digite a Descrição da Série: ");
			string entradaDescricao = Console.ReadLine();

			foreach (int i in Enum.GetValues(typeof(Genero)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
			}
			Console.Write("Digite o gênero entre as opções acima: ");
			int entradaGenero = int.Parse(Console.ReadLine());
			Console.Write("Digite a quantidade de temporada da Série: ");
			int entradaTemporada = int.Parse(Console.ReadLine());
           
            Console.Write("Digite a Classificacao da Série: ");
			int entradaClassificacao = int.Parse(Console.ReadLine());

			Console.Write("Digite o Ano de Início da Série: ");
			int entradaAno = int.Parse(Console.ReadLine());

			Console.Write("Digite o elenco da Série: ");
			string entradaElenco = Console.ReadLine();

			Serie atualizaSerie = new Serie(id: indiceSerie,
            							titulo: entradaTitulo,
                                        descricao: entradaDescricao,
										genero: (Genero)entradaGenero,
										temporada: entradaTemporada,
                                        classificacao: entradaClassificacao,
										ano: entradaAno,
										elenco: entradaElenco);

			repositorio.Atualiza(indiceSerie, atualizaSerie);
		}

private static void InserirFilme()
		{
				
			Console.Write("Digite o Título do Filme: ");
			string entradaTitulo = Console.ReadLine();

            Console.Write("Digite a Descrição do filme: ");
			string entradaDescricao = Console.ReadLine();

			foreach (int i in Enum.GetValues(typeof(Genero)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
			}
			Console.Write("Digite o gênero entre as opções acima: ");
			int entradaGenero = int.Parse(Console.ReadLine());
		
			Console.Write("Digite o tempo(Min) do Filme: ");
			int entradaDuracao = int.Parse(Console.ReadLine());
           
            Console.Write("Digite a Classificacao do Filme: ");
			int entradaClassificacao = int.Parse(Console.ReadLine());

			Console.Write("Digite o Ano de Lançamento do Filme: ");
			int entradaAno = int.Parse(Console.ReadLine());

			Console.Write("Digite o elenco do Filme: ");
			string entradaElenco = Console.ReadLine();

			Filme novaFilme = new Filme(id: repositorioFilme.ProximoId(),
            							titulo: entradaTitulo,
                                        descricao: entradaDescricao,
										genero: (Genero)entradaGenero,
										duracao: entradaDuracao,
                                        classificacao: entradaClassificacao,
										ano: entradaAno,
										elenco: entradaElenco);
			repositorioFilme.Insere(novaFilme);
		}
		

private static void InserirSerie()
		{
			
			Console.WriteLine("Inserir nova série");

            
			Console.Write("Digite o Título da Série: ");
			string entradaTitulo = Console.ReadLine();

            Console.Write("Digite a Descrição da Série: ");
			string entradaDescricao = Console.ReadLine();

			foreach (int i in Enum.GetValues(typeof(Genero)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
			}
			Console.Write("Digite o gênero entre as opções acima: ");
			int entradaGenero = int.Parse(Console.ReadLine());
			

			Console.Write("Digite a quantidade de temporada da Série: ");
			int entradaTemporada = int.Parse(Console.ReadLine());
           
            Console.Write("Digite a Classificacao da Série: ");
			int entradaClassificacao = int.Parse(Console.ReadLine());

			Console.Write("Digite o Ano de Início da Série: ");
			int entradaAno = int.Parse(Console.ReadLine());

			Console.Write("Digite o elenco da Série: ");
			string entradaElenco = Console.ReadLine();

			Serie novaSerie = new Serie(id: repositorio.ProximoId(),
            							titulo: entradaTitulo,
                                        descricao: entradaDescricao,
										genero: (Genero)entradaGenero,
										temporada: entradaTemporada,
                                        classificacao: entradaClassificacao,
										ano: entradaAno,
										elenco: entradaElenco);
			repositorio.Insere(novaSerie);
		}
		private static void ListarFilmes()
		{
			Console.WriteLine("Listar Filmes");

			var listaFilme = repositorioFilme.Lista();

			if (listaFilme.Count == 0)
			{
				Console.WriteLine("Nenhuma série cadastrada.");
				return;
			}

			foreach (var filme in listaFilme)
			{
                var favorito = filme.retornaFavoritado();
                var excluido = filme.retornaExcluido();
                
				Console.WriteLine("#ID {0}: - {1} {2} {3}", filme.retornaId(), filme.retornaTitulo(), (excluido ? "*Excluído*" : ""), (favorito ? "*Adicionado aos Favoritos*" : ""));
			}
		}
        private static void ListarSeries()
		{
			Console.WriteLine("Listar séries");

			var lista = repositorio.Lista();

			if (lista.Count == 0)
			{
				Console.WriteLine("Nenhuma série cadastrada.");
				return;
			}

			foreach (var serie in lista)
			{
                var favorito = serie.retornaFavoritado();
                var excluido = serie.retornaExcluido();
                
				Console.WriteLine("#ID {0}: - {1} {2} {3}", serie.retornaId(), serie.retornaTitulo(), (excluido ? "*Excluído*" : ""), (favorito ? "*Adicionado aos Favoritos*" : ""));
			}
		}
private static string ObterOpcaoUsuario()
		{
			Console.WriteLine();
			Console.WriteLine("Bem vindos ao NetSeries!!!");
			Console.WriteLine("1- Inserir ");
			Console.WriteLine("2- Listar ");
			Console.WriteLine("3- Atualizar");
			Console.WriteLine("4- Excluir ");
            Console.WriteLine("5- Adicionar aos Favoritos" );
			Console.WriteLine("6- Visualizar");
			Console.WriteLine("7- Relátorios");
			Console.WriteLine("8- Limpar Tela");
			Console.WriteLine("9- Sair");
			Console.WriteLine("Informe a opção desejada:");
			Console.WriteLine();

			string opcaoUsuario = Console.ReadLine();
			Console.WriteLine();
			return opcaoUsuario;
		}
		public static int ObterEscolha()
		{
				
					Console.WriteLine("1 - filme");
					Console.WriteLine("2 - Serie");
					Console.WriteLine("escolha a opção desejada:");
					Console.WriteLine();
					int escolha = int.Parse(Console.ReadLine());
					return escolha;
		}
		
    }
}
