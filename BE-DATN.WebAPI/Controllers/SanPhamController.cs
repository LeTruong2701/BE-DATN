using BE_DATN.Application.BUS.Admin.Interfaces;
using BE_DATN.Application.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BE_DATN.WebAPI.Controllers
{
    [ApiController]
    [Route("api/admin")]
    public class SanPhamController : ControllerBase
    {
        private readonly IManageSanPham _manageSanPham;
        public SanPhamController(IManageSanPham manageSanPham)
        {
            _manageSanPham = manageSanPham;
        }


        [Route("getall-sanpham")]
        [HttpGet]
        public async Task<IActionResult> get()
        {
            var products = await _manageSanPham.Get();
            if (products == null)
            {
                return BadRequest("Get Failed");
            }

            return Ok(products);
        }

        [Route("create-sanpham")]
        [HttpPost]
        public async Task<IActionResult> create([FromBody] SanPhamRequest sanpham)
        {
            var sanphams = await _manageSanPham.Create(sanpham);
            if (sanphams == null)
            {
                return BadRequest("Get Failed");
            }

            return Ok(sanphams);
        }
    }
}
