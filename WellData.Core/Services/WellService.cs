using System;
using System.Collections.Generic;
using System.Text;
using WellData.Core.Models;

namespace WellData.Core.Services
{
    public class WellService : IWellService
    {
        private IWellRepository _wellRepository;

        public WellService(IWellRepository wellRepository)
        {
            _wellRepository = wellRepository;
        }
        public Well Add(Well addWell)
        {
            return _wellRepository.Add(addWell);
        }

        public Well Get(int id)
        {
            return _wellRepository.Get(id); 
        }

        public IEnumerable<Well> GetAll()
        {
            return _wellRepository.GetAll();
        }

        public void Remove(Well removeWell)
        {
            _wellRepository.Remove(removeWell);
        }

        public Well Update(Well updateWell)
        {
            Well well = _wellRepository.Update(updateWell);
            return well;
        }
    }
}
