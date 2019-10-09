using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreBase.Data;
using AspNetCoreBase.Models;
using Microsoft.AspNetCore.Hosting.Internal;

namespace AspNetCoreBase.Services
{
    public class PessoaServiceEF:IPessoaService
    {
        private readonly Context _context;

        public PessoaServiceEF(Context context)
        {
            _context = context;
        }

        public void Add(Pessoa pessoa)
        {
            _context.Add(pessoa);
        }

        public IEnumerable<Pessoa> GetAll()
        {
            return _context.Pessoas;
        }

        public Pessoa GetById(int id)
        {
            return _context.Pessoas.Find(id);
        }
    }
}
