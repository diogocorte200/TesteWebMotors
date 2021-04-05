using System;
using System.Collections.Generic;
using System.Text;
using TesteWebMotors.Entity.Entity;
using TesteWebMotors.Entity.Repositories.Interfaces;
using TesteWebMotors.Entity.Context;
using TesteWebMotors.Entity.Repository;

namespace TesteWebMotors.Entity.Repositories
{
    public class AnuncionRepository : Repository<AnuncioWebMotorsEntity>, IAnuncioRepository
    {
        private WebMotorsContext _appContext => (WebMotorsContext)_context;

        public AnuncionRepository(WebMotorsContext context) : base(context)
        { }
    }
}
