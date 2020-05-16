using System;
using System.Collections.Generic;
using System.Text;
using WellData.Core.Models;

namespace WellData.Core.Services
{
    public class UnitTypeService : IUnitTypeService
    {
        private IUnitTypeRepository _unitTypeRepository;

        public UnitTypeService(IUnitTypeRepository unitTypeRepository)
        {
            _unitTypeRepository = unitTypeRepository;
        }

        public UnitType Add(UnitType addUnitType)
        {
            _unitTypeRepository.Add(addUnitType);
            return addUnitType;
        }

        public UnitType Get(int id)
        {
            return _unitTypeRepository.Get(id);
        }

        public IEnumerable<UnitType> GetAll()
        {
            return _unitTypeRepository.GetAll();
        }

        public void Remove(UnitType removeUnitType)
        {
            _unitTypeRepository.Remove(removeUnitType);
        }

        public UnitType Update(UnitType updateUnitType)
        {
            UnitType unitType = _unitTypeRepository.Update(updateUnitType);
            return unitType;
        }
    }
}
