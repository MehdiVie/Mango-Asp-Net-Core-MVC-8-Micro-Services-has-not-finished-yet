﻿using Mango.Web.Models;


namespace Mango.Web.Service.IService
{
    public interface ICouponService
    {
        Task<ResponseDto?> GetCouponAsync(string couponCode);
        Task<ResponseDto?> GetAllCouponsAsync();
        Task<ResponseDto?> GetCouponByIdAsync(int couponId);
        Task<ResponseDto?> CreateCouponAsync(CouponDto coupondto);
        Task<ResponseDto?> UpdateCouponAsync(CouponDto coupondto);
        Task<ResponseDto?> DeleteCouponAsync(int couponId);

    }
}
