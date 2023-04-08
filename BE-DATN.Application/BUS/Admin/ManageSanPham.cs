using BE_DATN.Application.BUS.Admin.Interfaces;
using BE_DATN.Application.Common;
using BE_DATN.Data.EF;
using BE_DATN.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace BE_DATN.Application.BUS.Admin
{
    public class ManageSanPham :IManageSanPham
    {
        private readonly BEDATNDbContext _context;
        public ManageSanPham(BEDATNDbContext context)
        {
            _context = context;
        }


        public  async Task<List<SanPhamViewModel>> Get()
        {
            var data = from sp in _context.SanPhams
                           
                           select new { sp.IdSanPham, sp.TenSanPham, sp.MoTaSanPham, sp.IdDanhMuc, sp.NgayTao, sp.AnhSanPham, sp.IdThuongHieu ,sp.TrangThai};
                var result = data.Select(a => new { a.IdSanPham, a.IdDanhMuc, a.TenSanPham, a.MoTaSanPham, a.AnhSanPham,a.IdThuongHieu, a.NgayTao, a.TrangThai }).ToList();
            return await data.Select(x => new SanPhamViewModel()
            {
                IdSanPham=x.IdSanPham,
                IdDanhMuc=x.IdDanhMuc,
                TenSanPham=x.TenSanPham,
                MoTaSanPham=x.MoTaSanPham,
                AnhSanPham=x.AnhSanPham,
                IdThuongHieu=x.IdThuongHieu,
                NgayTao=x.NgayTao,
                TrangThai=x.TrangThai

            }).ToListAsync();

        }

        public Task<IAsyncResult> GetAllByCategoryPaging(int? Category_Id, int pageindex, int pagesize, string filter, int? lowprice, int? highprice)
        {
            throw new NotImplementedException();
        }

        public Task<IAsyncResult> GetAllPaging(int? Category_Id, int pageindex, int pagesize, string keyword)
        {
            throw new NotImplementedException();
        }

        public Task<SanPhamViewModel> GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<SanPham>> Search(string Name)
        {
            throw new NotImplementedException();
        }

        public async Task<int> Create(SanPhamRequest sp)
        {
            var sanpham = new SanPham()
            {
                
                IdDanhMuc = sp.IdDanhMuc,
                TenSanPham = sp.TenSanPham,
                MoTaSanPham =sp.MoTaSanPham,
                AnhSanPham = sp.AnhSanPham,
                IdThuongHieu=sp.IdThuongHieu,
                NgayTao =DateTime.Now,
                TrangThai = sp.TrangThai,

            };

            _context.SanPhams.Add(sanpham);

            await _context.SaveChangesAsync();

          
            return 1;
        }
        public Task<int> Update(SanPhamRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<int> Delete(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
