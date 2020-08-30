using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EnsekTest.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace EnsekTest.Web.Controllers
{
    public class MeterReadingsController : Controller
    {
        private IMeterReadingService _meterReadingService;
        public MeterReadingsController(IMeterReadingService meterReadingService)
        {
            _meterReadingService = meterReadingService;
        }

        public async Task<IActionResult> Index()
        {
            var meterReadings = await _meterReadingService.GetMeterReadingsAsync();

            return View(meterReadings);
        }
    }
}
