using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Urbanization.Data.Models;
using Urbanization.WebApp.Abstractions;

namespace Urbanization.WebApp.Controllers
{
    public class UrbanizationController
    {
        private IUrbanizationByStateService _UrbanizationByStateService;

        public UrbanizationController(IUrbanizationByStateService urbanizationByStateService)
        {
            _UrbanizationByStateService = urbanizationByStateService;
        }

        [HttpGet]
        public ICollection<UrbanizationByState> GetStatesUrbanization()
        {
            return null;
        }
    }
}
