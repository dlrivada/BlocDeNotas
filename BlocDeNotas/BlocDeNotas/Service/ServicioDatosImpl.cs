using System.Threading.Tasks;
using BlocDeNotas.Model;
using BlocDeNotas.Util;
using Microsoft.WindowsAzure.MobileServices;

namespace BlocDeNotas.Service
{
    public class ServicioDatosImpl:IServicioDatos
    {
        private MobileServiceClient client;

        public ServicioDatosImpl()
        {
            client=new MobileServiceClient(Cadenas.UrlServicio, Cadenas.TokenServicio);
        }

        public Task<Usuario> ValidarUsuario(Usuario usuario)
        {
            throw new System.NotImplementedException();
        }

        public Task<Usuario> AddUsuario(Usuario usuario)
        {
            throw new System.NotImplementedException();
        }

        public Task<Usuario> UpdateUsuario(Usuario usuario, string id)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteUsuario(string id)
        {
            throw new System.NotImplementedException();
        }
    }
}