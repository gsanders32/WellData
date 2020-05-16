using System;
using System.Collections.Generic;
using System.Text;
using WellData.Core.Models;

namespace WellData.Core.Services
{
    public interface IWellService
    {
        Well Add(Well addWell);
        Well Get(int id);
        IEnumerable<Well> GetAll();
        Well Update(Well updateWell);
        void Remove(Well removeWell);
    }
}
