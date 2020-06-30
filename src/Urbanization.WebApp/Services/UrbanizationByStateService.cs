using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Urbanization.Data.Abstractions;
using Urbanization.Data.Models;
using Urbanization.WebApp.Abstractions;

namespace Urbanization.WebApp.Services
{
    public class UrbanizationByStateService : IUrbanizationByStateService
    {
        private IUrbanizationByStateStore _UrbanizationByStateStore;
        public UrbanizationByStateService(IUrbanizationByStateStore urbanizationByStateStore)
        {
            _UrbanizationByStateStore = urbanizationByStateStore;
        }

        public ICollection<UrbanizationByState> GetStateUrbanization()
        {
            throw new NotImplementedException();
        }
    }
}
