using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Refit;

namespace Inventarios
{
    public interface IUsuarioLogin
    {
        [Get("/_controllers/CredencialesController.php?instrucion=0&ID_USUARIO=PLJC01&PASSWORD=57CF06A59E2D9DBEB946D2BFF2C26A0C")]
        Task<string> GetUsuarioAsync(string ID_USUARIO, string PASSWORD, int instrucion = 0);
    }
}
