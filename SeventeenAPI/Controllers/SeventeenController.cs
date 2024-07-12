using Microsoft.AspNetCore.Mvc;
using SvtBL;
using Microsoft.AspNetCore.Mvc.Formatters;
using System.Reflection.Metadata.Ecma335;
using SvtDL;
using Carat;

namespace SeventeenAPI.Controllers
{
    [ApiController]
    [Route("api/discography")]
    public class SeventeenController : ControllerBase
    {
        SvtGetServices _getServices;
        SvtTransactionServices _transactionServices;

        public SeventeenController()
        {
            _getServices = new SvtGetServices();
            _transactionServices = new SvtTransactionServices();
        }

        [HttpGet]
        public IEnumerable<SeventeenAPI.Seventeen> GetDiscography()
        {
            var Discography = _getServices.GetAllDiscography();

            List<SeventeenAPI.Seventeen> cont = new List<SeventeenAPI.Seventeen>();

            foreach (var discography in Discography)
            {
                cont.Add(new SeventeenAPI.Seventeen { Albumtype = discography.Albumtype, Title = discography.Title });
            }
            return cont;
        }
        [HttpPost]
        public JsonResult CreateDiscography(Discography request)
        {
            var result = _transactionServices.CreateDiscography(request.Albumtype, request.Title);

            return new JsonResult(result);
        }
        [HttpPatch]
        public JsonResult UpdateDiscography(Discography request)
        {
            var result = _transactionServices.UpdateDiscography(request.Albumtype, request.Title);

            return new JsonResult(result);

        }

    }


}