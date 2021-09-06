using System.Collections.Generic;
namespace ProjetoDecolaSeries.Interface
{
    public interface IRepositorio<T>
    {
        List<T> Lista();
        T RetornaPorId(int id);        
        void Insere(T entidade);        
        void Exclui(int id);
        void Favorita(int id);        
        void Atualiza(int id, T entidade);
        int ProximoId();
        void Mostratodos();
      
    }
}