
using System.Collections.Generic;

namespace register_app.Interfaces
{
    public interface IRepositorio<T>
    {
        List<T> Lista();
        T RetornaPorId(int id);        
        void Insere(T entidade);        
        void Exclui(int id);        
        void Atualiza(int id, T entidade);
        int ProximoId();
    }
}