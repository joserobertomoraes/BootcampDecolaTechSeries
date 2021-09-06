using System;
namespace ProjetoDecolaSeries
{
    public class Serie : EntidadeBase
    {
        private string Titulo {get; set;}
        private string Descricao {get; set;}
        private Genero Genero {get; set;}
        private int Temporada {get; set;}
        private int Classificacao {get; set;}
        private int Ano {get; set;}
        private string Elenco {get; set;}
        private bool Excluido {get; set;}
        private bool Favoritado {get; set;}

        public Serie(int id, string titulo,string descricao, Genero genero, int temporada,int classificacao, int ano, string elenco)
        {
            this.Id = id;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Genero = genero;
            this.Temporada = temporada;
            this.Classificacao = classificacao;
            this.Ano = ano;
            this.Elenco = elenco;
            this.Excluido = false;
            this.Favoritado = false;
        }
         public override string ToString()
		{
			// Environment.NewLine https://docs.microsoft.com/en-us/dotnet/api/system.environment.newline?view=netcore-3.1
            string retorno = "";
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
              retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Temporada: " + this.Temporada + Environment.NewLine;
            retorno += "Classificação: " + this.Classificacao + Environment.NewLine;
            retorno += "Ano de Início: " + this.Ano + Environment.NewLine;
             retorno += "Elenco: " + this.Elenco + Environment.NewLine;
            retorno += "Excluido: " + this.Excluido + Environment.NewLine;;
             retorno += "Favorito: " + this.Favoritado;
			return retorno;
		}
         public string retornaTitulo()
		{
			return this.Titulo;
		}

		public int retornaId()
		{
			return this.Id;
		}
        public bool retornaExcluido()
		{
			return this.Excluido;
		}
        public bool retornaFavoritado()
        {
            return this.Favoritado;
        }
        public void Excluir() {
            this.Excluido = true;
        }
          public void Favoritar() {
            this.Favoritado = true;
        }

    }
}