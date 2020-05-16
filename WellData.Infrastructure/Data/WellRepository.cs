using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using WellData.Core.Models;
using WellData.Core.Services;

namespace WellData.Infrastructure.Data
{
    public class WellRepository : IWellRepository
    {
        private readonly AppDbContext _dbContext;

        public WellRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Well Add(Well addWell)
        {
            Well well = addWell;
            if (well != null)
            {
                _dbContext.Wells.Add(well);
                _dbContext.SaveChanges();
                return well;
            }
            return null;
        }

        public Well Get(int id)
        {
            Well well = _dbContext.Wells
                .Include(x => x.Flows)
                .ThenInclude(x => x.UnitType.Abbreviation)
                .Include(x => x.WaterLevels)
                .FirstOrDefault(x => x.Id == id);
            if (well != null)
            {
                return well;
            }
            return null;
        }

        public IEnumerable<Well> GetAll()
        {
            var well = _dbContext.Wells
                .Include(x => x.Flows)
                .ThenInclude(x=>x.UnitType.Abbreviation)
                .Include(x => x.WaterLevels).ToList();
            if (well != null)
            {
                return well;
            }
            return null;
        }

        public void Remove(Well removeWell)
        {
            Well well = _dbContext.Wells.FirstOrDefault(x => x.Id == removeWell.Id);
            if (well != null)
            {
                _dbContext.Remove(well);
                _dbContext.SaveChanges();
            }
        }

        public Well Update(Well updateWell)
        {
            Well well = _dbContext.Wells.FirstOrDefault(x => x.Id == updateWell.Id);
            if (well != null)
            {
                _dbContext.Entry(well)
                    .CurrentValues
                    .SetValues(updateWell);
                _dbContext.Update(well);
                _dbContext.SaveChanges();
                return well;
            }
            return null;
        }
    }
}
