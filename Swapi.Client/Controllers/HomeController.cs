using System.Web.Mvc;
using Swapi.Data.Contracts;
using Swapi.Data.Helpers;
using System.Threading.Tasks;
using Swapi.Data.Enums;
using Swapi.Client.Configurations;
using System;

namespace Swapi.Client.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppConfig _appConfig;
        private readonly IHttpHelper _httpHelper;
        private readonly IFileHelper _fileHelper;

        public HomeController()
        {
            _appConfig = new AppConfig();
            _httpHelper = new HttpHelper(_appConfig.starWarsAPIUrl);
            _fileHelper = new FileHelper();
        }

        public ActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public async Task<bool> SaveEntity(string entity, int id)
        {
            bool isSaved = false;
            StarWarsEntities entityValue;
            var isValid = Enum.TryParse(entity, out entityValue) ;
            var content = isValid ? await _httpHelper.GetJsonResponse(entityValue.ToString(), id) : string.Empty;
            if (!string.IsNullOrWhiteSpace(content))
            {
                isSaved = await _fileHelper.SaveFile(_appConfig.filePath, $"{entityValue.ToString()}.txt", content);
            }
            return isSaved;
        }
    }
}