using Microsoft.AspNetCore.Mvc;
using SvtBL;
using Microsoft.AspNetCore.Mvc.Formatters;
using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Http;
using Carat;
using System.Threading.Tasks;

namespace SeventeenAPI.Controllers
{
    [ApiController]
    [Route("api/discography")]
    public class SeventeenController : ControllerBase
    {
        private readonly SvtGetServices _getServices;
        private readonly SvtTransactionServices _transactionServices;
        private readonly S3Services _s3Service;
        private readonly string _accessKey = "";
        private readonly string _secretKey = "";
        private readonly string _bucketName = "akalmenanza";
        private readonly Amazon.RegionEndpoint _region = Amazon.RegionEndpoint.USEast1;

        public SeventeenController(S3Services s3Service)
        {
            _getServices = new SvtGetServices(); 
            _transactionServices = new SvtTransactionServices(); 
        }

        
        [HttpGet]
        public IEnumerable<Seventeen> GetDiscography()
        {
            var discographies = _getServices.GetAllDiscography();

            List<Seventeen> cont = new List<Seventeen>();

            
            foreach (var discography in discographies)
            {
                cont.Add(new Seventeen { Albumtype = discography.Albumtype, Title = discography.Title });
            }
            return cont;
        }

        
        [HttpPost]
        public JsonResult CreateDiscography([FromBody] Seventeen request)
        {
            if (request == null)
            {
                return new JsonResult("Invalid input data") { StatusCode = 400 };
            }

            var result = _transactionServices.CreateDiscography(request.Albumtype, request.Title);

            return new JsonResult(result);
        }

        
        [HttpPatch]
        public JsonResult UpdateDiscography([FromBody] Seventeen request)
        {
            if (request == null)
            {
                return new JsonResult("Invalid input data") { StatusCode = 400 };
            }

            var result = _transactionServices.UpdateDiscography(request.Albumtype, request.Title);

            return new JsonResult(result);
        }

        
        [HttpDelete]
        public JsonResult DeleteDiscography([FromBody] Seventeen request)
        {
            if (request == null)
            {
                return new JsonResult("Invalid input data") { StatusCode = 400 };
            }

            
            var discographyToDelete = new Carat.Discography
            {
                Albumtype = request.Albumtype
            };

            var result = _transactionServices.DeleteDiscography(discographyToDelete);

            return new JsonResult(result);
        }

        
        [HttpPost("upload")]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> UploadFile(IFormFile file)
        {
            if (file == null || file.Length == 0)
            {
                return BadRequest("No file provided.");
            }

            try
            {
                var result = await _s3Service.UploadFileAsync(file);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}
