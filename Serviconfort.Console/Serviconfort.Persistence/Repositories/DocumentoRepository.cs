using Serviconfort.entities;
using Serviconfort.entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serviconfort.Persistence.Repositories
{
    public class DocumentoRepository: Repository<Documento>,IDocumentoRepository
    {
    }
}
