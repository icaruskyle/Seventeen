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
        public IEnumerable<SeventeenAPI.Discography> GetDiscography()
        {
            var Discography = _getServices.GetAllDiscography();

            List<SeventeenAPI.Discography> cont = new List<SeventeenAPI.Discography>();

            foreach (var discography in Discography)
            {
                cont.Add(new SeventeenAPI.Discography { Albumtype = discography.Albumtype, Title = discography.Title });
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
        [HttpDelete]
        public JsonResult DeleteDiscograhy(SeventeenAPI.Discography request)
        {

            var delete = new Carat.Discography
            {
                Albumtype = request.Albumtype

            };

            var result = _transactionServices.DeleteDiscography(delete);

            return new JsonResult(result);
        }

    }


}
       
