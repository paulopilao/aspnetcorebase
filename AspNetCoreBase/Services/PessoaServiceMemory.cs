using System.Collections.Generic;
using System.Linq;
using AspNetCoreBase.Models;

namespace AspNetCoreBase.Services
{
    public class PessoaServiceMemory:IPessoaService
    {
        private  readonly  List<Pessoa> _pessoas;
        public PessoaServiceMemory()
        {
            _pessoas = new List<Pessoa>()
            {
                new Pessoa{Id = 1,Nome = "Paulo",Cpf = "123"},
                new Pessoa{Id = 2,Nome = "Fabiana",Cpf = "564"},
                new Pessoa{Id = 3,Nome = "Thales",Cpf = "432"},
                new Pessoa{Id = 4,Nome = "Agnes",Cpf = "987"},
            };
        }
        public void Add(Pessoa pessoa)
        {
            _pessoas.Add(pessoa);
        }

        public IEnumerable<Pessoa> GetAll()
        {
            return _pessoas;
        }

        public Pessoa GetById(int id)
        {
            return _pessoas.FirstOrDefault(x => x.Id == id);
        }
    }
}