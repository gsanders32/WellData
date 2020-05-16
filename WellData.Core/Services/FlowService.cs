using System;
using System.Collections.Generic;
using System.Text;
using WellData.Core.Models;

namespace WellData.Core.Services
{
    public class FlowService : IFlowService
    {
        private IFlowRepository _flowRepository;

        public FlowService(IFlowRepository flowRepository)
        {
            _flowRepository = flowRepository;
        }
        public Flow Add(Flow addFlow)
        {
            return _flowRepository.Add(addFlow);
        }

        public Flow Get(int id)
        {
            return _flowRepository.Get(id);
        }

        public IEnumerable<Flow> GetAll()
        {
            return _flowRepository.GetAll();
        }

        public void Remove(Flow removeFlow)
        {
            _flowRepository.Remove(removeFlow);
        }

        public Flow Update(Flow updateFlow)
        {
            Flow flow = _flowRepository.Update(updateFlow);
            return flow;
        }
    }
}
