using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Domain.Entity;
using Domain.Interface;
using Microsoft.EntityFrameworkCore;

namespace Infra.Repository
{
    public class RepositoryPessoa : IPessoa
    {

        private readonly AppContextDB _db;

        public RepositoryPessoa(AppContextDB db)
        {
            _db = db;
        }

        public async Task<Pessoa> Adicionar(Pessoa pessoa)
        {
            if (pessoa == null)
            {
                throw new ArgumentNullException(nameof(pessoa));
            }
            var p = await _db.Pessoas.AddAsync(pessoa);
            await _db.SaveChangesAsync();
            return pessoa;
        }


        public async Task<Pessoa> BuscarId(int id)
        {
            var pessoa = await _db.Pessoas.FindAsync(id);
            if (pessoa == null)
            {
                throw new ArgumentException("Deu erro na busca");
            }
            return pessoa;
        }

        public async Task<IEnumerable<Pessoa>> buscarTodos()
        {
            return await _db.Pessoas.ToListAsync();
        }

        public async Task<Pessoa> Remover(int id)
        {
            var pessoa = await BuscarId(id);
            if (pessoa == null)
            {
                throw new ArgumentException("Deu erro no remove");
            }
            _db.Pessoas.Remove(pessoa);
            return pessoa;
        }

        public void Update(Pessoa pessoa)
        {
            if (pessoa == null)
            {
                throw new ArgumentException("Deu erro no update"); 
            }
            _db.Pessoas.Update(pessoa);
        }
    }
}
