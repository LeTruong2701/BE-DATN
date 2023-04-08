using BE_DATN.Application.Common;
using BE_DATN.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BE_DATN.Application.BUS.Admin.Interfaces
{
    public interface IManageSanPham
    {
        Task<List<SanPham>> Search(string Name);
        Task<List<SanPhamViewModel>> Get();
        Task<IAsyncResult> GetAllByCategoryPaging(int? Category_Id, int pageindex, int pagesize, string filter, int? lowprice, int? highprice);
        Task<IAsyncResult> GetAllPaging(int? Category_Id, int pageindex, int pagesize, string keyword);
        Task<SanPhamViewModel> GetById(int Id);
        Task<int> Create(SanPhamRequest request);
        Task<int> Update(SanPhamRequest request);
        Task<int> Delete(int Id);
    }
}
