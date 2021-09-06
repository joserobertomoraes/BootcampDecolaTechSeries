using System;
using System.Collections.Generic;
using ProjetoDecolaSeries.Interface;
namespace ProjetoDecolaSeries
{
    public class SerieRepositorio : IRepositorio<Serie>
	{
        private List<Serie> listaSerie = new List<Serie>();
		public void Atualiza(int id, Serie objeto)
		{
			listaSerie[id] = objeto;
		}

		public void Exclui(int id)
		{
			listaSerie[id].Excluir();
		}
        public void Favorita(int id)
		{
			listaSerie[id].Favoritar();
		}

		public void Insere(Serie objeto)
		{
			listaSerie.Add(objeto);
		}
		public void Mostratodos()
		{
			foreach(var elemento in listaSerie)
				{
   					 Console.WriteLine(elemento);
					Console.WriteLine();
					Console.WriteLine("------------------");
				}
		}

		public List<Serie> Lista()
		{
			return listaSerie;
		}

		public int ProximoId()
		{
			return listaSerie.Count;
		}

		public Serie RetornaPorId(int id)
		{
			return listaSerie[id];
		}
		
	}
}