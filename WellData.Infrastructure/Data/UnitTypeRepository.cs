using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WellData.Core.Models;
using WellData.Core.Services;

namespace WellData.Infrastructure.Data
{
    public class UnitTypeRepository : IUnitTypeRepository
    {
        private readonly AppDbContext _dbContext;
        public UnitTypeRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public UnitType Add(UnitType addUnitType)
        {
            UnitType unitType = addUnitType;
            if (unitType != null)
            {
                _dbContext.Add(addUnitType);
                _dbContext.SaveChanges();
                return addUnitType;
            }
            return null;
        }

        public UnitType Get(int id)
        {
            UnitType unitType = _dbContext.UnitTypes.FirstOrDefault(x => x.Id == id);
            if (unitType != null)
            {
                return unitType;
            }
            return null;
        }

        public IEnumerable<UnitType> GetAll()
        {
            var unitType = _dbContext.UnitTypes.ToList();
            if (unitType != null)
            {
                return unitType;
            }
            return null;
        }

        public void Remove(UnitType removeUnitType)
        {
            UnitType unitType = _dbContext.UnitTypes.FirstOrDefault(x => x.Id == removeUnitType.Id);
            if (unitType != null)
            {
                _dbContext.UnitTypes.Remove(unitType);
                _dbContext.SaveChanges();
            }
        }

        public UnitType Update(UnitType updateUnitType)
        {
            UnitType unitType = _dbContext.UnitTypes.FirstOrDefault(x => x.Id == updateUnitType.Id);
            if (unitType != null)
            {
                _dbContext.Entry(unitType)
                    .CurrentValues.SetValues(updateUnitType);
                _dbContext.Update(unitType);
                _dbContext.SaveChanges();
                return unitType;
            }
            return null;
        }
    }
}
