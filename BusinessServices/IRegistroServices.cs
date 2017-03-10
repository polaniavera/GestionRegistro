using BusinessEntities;
using System.Collections.Generic;

namespace BusinessServices
{
    /// <summary>
    /// Registro Service Contract
    /// </summary>
    public interface IRegistroServices
    {
        RegistroEntity GetRegistroById(int registroId);
        IEnumerable<RegistroEntity> GetAllRegistros();
        int CreateRegistro(RegistroEntity registroEntity);
        bool UpdateRegistro(int registroId, RegistroEntity registroEntity);
        bool DeleteRegistro(int registroId);
    }
}
