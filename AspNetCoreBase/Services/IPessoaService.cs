using System.Collections.Generic;
using AspNetCoreBase.Models;
using Microsoft.EntityFrameworkCore.Internal;

namespace AspNetCoreBase.Services
{
    public interface IPessoaService
    {
        void Add(Pessoa pessoa);
        IEnumerable<Pessoa> GetAll();
        Pessoa GetById(int id);
    }
}