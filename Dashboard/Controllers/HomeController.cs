using Dashboard.Brokers.Storages;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Dashboard.Controllers
{
    public class HomeController:Controller
    {
        private readonly StorageBroker storageBroker;

        public HomeController(StorageBroker storageBroker)
        {
            this.storageBroker = storageBroker;
        }

        public async Task<IActionResult> Index()
        {
            return  View();
        }
    }
}
