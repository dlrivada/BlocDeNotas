using System.Threading.Tasks;
using BlocDeNotas.Model;

namespace BlocDeNotas.Service
{
    public interface IServicioDatos
    {
        #region Usuario

        Task<Usuario> ValidarUsuario(Usuario usuario);
        Task<Usuario> AddUsuario(Usuario usuario);
        Task<Usuario> UpdateUsuario(Usuario usuario, string id);
        Task DeleteUsuario(string id);

        #endregion

    }
}