using AutoMapper;
using BestProjects.Data.EntityData;
using BestProjects.Data.Repository.Base;
using BestProjects.Domain.IRepository;
using BestProjects.Domain.Models.EntityDomain;
using System;
using System.Collections.Generic;
using System.Text;

namespace BestProjects.Data.Repository
{
    public class UsuarioRepository : RepositoryBase<Usuario, UsuarioData>, IUsuarioRepository
    {
        public UsuarioRepository(SqlDataContext dataContext, IMapper mapper) : base(dataContext, mapper)
        {
        }

    }
}
