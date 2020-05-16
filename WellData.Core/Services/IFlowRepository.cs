using System;
using System.Collections.Generic;
using System.Text;
using WellData.Core.Models;

namespace WellData.Core.Services
{
    public interface IFlowRepository
    {
        Flow Add(Flow addFlow);
        Flow Get(int id);
        IEnumerable<Flow> GetAll();
        Flow Update(Flow updateFlow);
        void Remove(Flow removeFlow);
    }
}
