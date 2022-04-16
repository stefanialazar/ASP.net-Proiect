using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LSD_233_DAW_BLL.Interfaces
{
    public interface IActorManager
    {
        Task<List<string>> ModifyActor();
    }
}
