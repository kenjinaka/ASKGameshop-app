using ASKGameShopAPI.Models;
using System.Collections.Generic;

namespace ASKGames.Dal
{
    public interface IDAL 
    {
       string Cadastrar(EntidadeDominio entidadeDominio);

       string Alterar(EntidadeDominio entidadeDominio);

       string Excluir(EntidadeDominio entidadeDominio);

       List<EntidadeDominio> Consultar(EntidadeDominio entidadeDominio);

       EntidadeDominio ConsultarId(EntidadeDominio entidadeDominio);

    }
}
