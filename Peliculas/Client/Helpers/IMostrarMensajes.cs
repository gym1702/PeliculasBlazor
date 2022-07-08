using System.Threading.Tasks;

namespace Peliculas.Client.Helpers
{
    public interface IMostrarMensajes
    {
        Task MostrarMensajeError(string mensaje);
    }
}
