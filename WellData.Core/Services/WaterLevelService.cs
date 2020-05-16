using System;
using System.Collections.Generic;
using System.Text;
using WellData.Core.Models;

namespace WellData.Core.Services
{
    public class WaterLevelService : IWaterLevelService
    {
        private IWaterLevelRepository _waterLevelRepository;

        public WaterLevelService(IWaterLevelRepository waterLevelRepository)
        {
            _waterLevelRepository = waterLevelRepository;
        }
        public WaterLevel Add(WaterLevel addWaterLevel)
        {
            return _waterLevelRepository.Add(addWaterLevel);
        }

        public WaterLevel Get(int id)
        {
            return _waterLevelRepository.Get(id);
        }

        public IEnumerable<WaterLevel> GetAll()
        {
            return _waterLevelRepository.GetAll();
        }

        public void Remove(WaterLevel removeWaterLevel)
        {
            _waterLevelRepository.Remove(removeWaterLevel);
        }

        public WaterLevel Update(WaterLevel updateWaterLevel)
        {
            WaterLevel waterLevel = _waterLevelRepository.Update(updateWaterLevel);
            return waterLevel;
        }
    }
}
