using Dashboard.Brokers.Storages;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Dashboard.Controllers
{
    public class RealController:Controller
    {
        private readonly StorageBroker storageBroker;

        public RealController(StorageBroker storageBroker)=>
            this.storageBroker = storageBroker;
        
        public IActionResult UnemploymentView()=>
            View();

        public async Task<IActionResult> UnemploymentData()
        {
            var data = await this.storageBroker.UnemploymentDatas
                .OrderBy(x => x.Year)
                .Select(x => new {
                    Year = x.Year.Year,   
                    x.Rate
                })
                .ToListAsync();

            return Json(data);
        }

        public IActionResult TradeView()=>
             View();
        
        public async Task<IActionResult> TradeData()
        {
            var trades = await this.storageBroker.TradeDatas
                .OrderBy(t => t.Year)
                .ToListAsync();

            return Json(trades.Select(t => new {
                year = t.Year.Year,
                export = t.Export,
                import = t.Import
            }));
        }

        public IActionResult SectorView()=>
            View();

        public async Task<IActionResult> SectorData()
        {
            var sectors = await this.storageBroker.SectorDatas
                .OrderBy(s => s.Year)
                .ToListAsync();

            return Json(sectors.Select(s => new {
                year = s.Year.Year,
                agriculture = s.Agriculture,
                industry = s.Industry,
                services = s.Services
            }));
        }

        public IActionResult InflationView()=> View();

        public async Task<IActionResult> InflationData()
        {
            var datas = await this.storageBroker.InflationDatas
                .OrderBy(year => year.Year)
                .ToListAsync();

            return Json(datas.Select(s => new
            {
                year = s.Year.Year,
                rate = s.Rate
            }));
        }

        public IActionResult GdpView() => View();

        public async Task<IActionResult> GdpData()
        {
            var data = await this.storageBroker.GdpDatas
                .OrderBy(g => g.Year)
                    .ToListAsync();

            return Json(data.Select(d => new {
                year = d.Year.Year,
                value = d.Value
            }));
        }

        public IActionResult DemographyView() => View();

        public async Task<IActionResult> DemographyData()
        {
            var datas = await this.storageBroker.DemographyDatas
                .OrderBy(d => d.Year).ToListAsync();

            return Json(datas.Select(s => new
            {
                year = s.Year.Year,
                population = s.Population,
                urban = s.UrbanPercent,
                rural = s.RuralPercent
            }));
        }

        public IActionResult CurrencyRateView()=>View();

        public async Task<IActionResult> CurrencyRateData()
        {
            var data = await this.storageBroker.CurrencyRateDatas
                .OrderBy(x => x.Year)
                .ToListAsync();

            return Json(data);
        }

        public IActionResult BudgetView() => View();

        public async Task<IActionResult> BudgetData()
        {
            var datas = await this.storageBroker.BudgetDatas
                .OrderBy(y => y.Year).ToListAsync();

            return Json(datas.Select(s => new
            {
                year = s.Year.Year,
                education = s.Education,
                healthcare = s.Healthcare,
                defense = s.Defense,
                infrastructure = s.Infrastructure,
                other = s.Other
            }));
        }

        public IActionResult DemographyGenderView() => View();

        public async Task<IActionResult> DemographyGenderData()
        {
            var datas = await this.storageBroker.DemographyGenderDatas
                .OrderBy(x => x.Year)
                .ToListAsync();

            return Json(datas.Select(d => new
            {
                year = d.Year.Year,
                male = d.Male,
                female = d.Female
            }));
        }
    }
}
