using AutoMapper;
using CleanAddress.Dadata.Client;
using CleanAddress.Model;
using Microsoft.AspNetCore.Mvc;

namespace CleanAddress.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class AddressController : ControllerBase
    {
        /// <summary>
        /// Клиент для взаимодействия с "DaData".
        /// </summary>
        private readonly DadataClient dadataClient;

        /// <summary>
        /// Маппер.
        /// </summary>
        private readonly IMapper mapper;

        public AddressController(DadataClient dadataClient, IMapper mapper)
        {
            this.dadataClient = dadataClient;
            this.mapper = mapper;
        }

        /// <summary>
        /// Отформатированный адрес.
        /// </summary>
        /// <param name="address">Адрес.</param>        
        [HttpGet]
        public async Task<IActionResult> GetCleanAddress([FromQuery] string address, CancellationToken cancellationToken)
        {
            var result = this.mapper.Map<Address>(await dadataClient.SendAddressToClean(address, cancellationToken));

            if (result == null)
            {
                return new JsonResult("Простите мы не смогли формализовать адрес.");
            }

            return new JsonResult(result);
        }
    }
}
