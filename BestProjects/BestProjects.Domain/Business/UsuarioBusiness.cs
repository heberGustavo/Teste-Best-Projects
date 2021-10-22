using BestProjects.Domain.Business.Base;
using BestProjects.Domain.IBusiness;
using BestProjects.Domain.IRepository;
using BestProjects.Domain.Models.EntityDomain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BestProjects.Domain.Business
{
    public class UsuarioBusiness : BusinessBase<Usuario>, IUsuarioBusiness
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioBusiness(IUsuarioRepository usuarioRepository) : base(usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public async Task<ResultResponseModel> CadastrarContato(Usuario usuario)
        {
            if (!string.IsNullOrEmpty(usuario.nome))
            {

                if (!string.IsNullOrEmpty(usuario.telefone))
                {
                    var resultado = await _usuarioRepository.CadastrarContato(usuario);

                    if(resultado == 1)
                        return new ResultResponseModel(false, "Contato " + usuario.nome + " cadastrado com sucesso!");
                    else
                        return new ResultResponseModel(true, "Erro ao cadastrar contato " + usuario.nome + ". Tente novamente!");

                }
                else
                {
                    return new ResultResponseModel(true, "Campo Telefone Res. é obrigatório");
                }

            }
            else
            {
                return new ResultResponseModel(true, "Campo Nome é obrigatório");
            }
        }
    }
}
