using BestProjects.Domain.Business.Base;
using BestProjects.Domain.IBusiness;
using BestProjects.Domain.IRepository;
using BestProjects.Domain.Models.EntityDomain;
using System;
using System.Collections.Generic;
using System.Text;

namespace BestProjects.Domain.Business
{
    public class UsuarioBusiness : BusinessBase<Usuario>, IUsuarioBusiness
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioBusiness(IUsuarioRepository usuarioRepository) : base(usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }
    }
}
