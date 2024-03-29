﻿
using Mango.Web.Models;


namespace Mango.Web.Service.IService
{
    public interface ICartService
    {
        Task<ResponseDto?> GetCartByUserIdAsync(string userId);
        Task<ResponseDto?> CartUpsertAsync(CartDto cartDto);
        Task<ResponseDto?> RemoveItemDetailsAsync(int detailsId);
        Task<ResponseDto?> ApplyCouponAsync(CartDto cartDto);
        Task<ResponseDto?> RemoveCouponAsync(CartDto cartDto);

        Task<ResponseDto?> EmailCartAsync(CartDto cartDto);

    }
}
