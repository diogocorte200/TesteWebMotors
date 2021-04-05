using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TesteWebMotors.Domain.Aggregate.WebMotors;

namespace TesteWebMotors.Domain.Aggregate
{
    public interface IWebMotorsClient
    {
        Task<IEnumerable<Marca>> ObterMarcas();
        Task<IEnumerable<Modelo>> ObterModelos(int id);
        Task<IEnumerable<Versao>> ObterVersoes(int id);

    }
}
