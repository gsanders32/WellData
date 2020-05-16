using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WellData.Core.Models;
using WellData.Core.Services;

namespace WellData.Infrastructure.Data
{
    public class FlowRepository : IFlowRepository
    {
        private readonly AppDbContext _dbContext;

        public FlowRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Flow Add(Flow addFlow)
        {
            Flow flow = addFlow;
            if (flow != null)
            {
                _dbContext.Add(flow);
                _dbContext.SaveChanges();
                return flow;
            }
            return null;
        }

        public Flow Get(int id)
        {
            Flow flow = _dbContext.Flows.Include(x => x.UnitType).FirstOrDefault(x => x.Id == id);
            if (flow != null)
            {
                return flow;
            }
            return null;
        }

        public IEnumerable<Flow> GetAll()
        {
            var flow = _dbContext.Flows.Include(x => x.UnitType).ToList();
            //var flow = _dbContext.Flows.ToList();
            if (flow != null)
            {
                return flow;
            }
            return null;
        }

        public void Remove(Flow removeFlow)
        {
            Flow flow = _dbContext.Flows.FirstOrDefault(x => x.Id == removeFlow.Id);
            if (flow != null)
            {
                _dbContext.Remove(flow);
                _dbContext.SaveChanges();
            }
        }

        public Flow Update(Flow updateFlow)
        {
            Flow flow = _dbContext.Flows.FirstOrDefault(x => x.Id == updateFlow.Id);
            if (flow != null)
            {
                _dbContext.Entry(flow)
                    .CurrentValues
                    .SetValues(updateFlow);
                _dbContext.Update(flow);
                _dbContext.SaveChanges();
                return flow;
            }
            return null;
        }
    }
}
