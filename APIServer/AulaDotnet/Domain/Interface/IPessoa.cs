using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entity;

namespace Domain.Interface
{
    public interface IPessoa
    {
        Task<IEnumerable<Pessoa>> buscarTodos();
        Task<Pessoa> BuscarId(int id);
        Task<Pessoa> Adicionar(Pessoa pessoa);
        Task<Pessoa> Remover(int id);

        void Update(Pessoa pessoa);
    }
}
