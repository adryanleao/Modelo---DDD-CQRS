﻿using Modelo.Domain.Models;

namespace Modelo.Domain.Interfaces
{
    public interface IFuncionarioRepository : IRepository<Funcionario>
    {
        Funcionario GetByEmail(string email);
    }
}
